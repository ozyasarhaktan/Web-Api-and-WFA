using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Models;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private readonly static string baseURL = "https://localhost:7237/api/products/";
        private void btnSave_Click(object sender,EventArgs e)
        {
            ProductDTO product = new ProductDTO()
            {
                ProductID = retrieveID,
                ProductName = txt_ProductName.Text,
                UnitPrice = Decimal.Parse(txt_UnitPrice.Text),
                UnitsInStock = Int16.Parse(txt_UnitsInStock.Text)
            };
            string jsonProduct = JsonConvert.SerializeObject(product);

            SendRESTRequest(baseURL,retrieveMethod,jsonProduct);
            MessageBox.Show("İşlem başarılı");
            this.Close();
        }

        public class ProductDTO
        {

            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public decimal? UnitPrice { get; set; }
            public Int16? UnitsInStock { get; set; }


        }

        private JObject SendRESTRequest(string uri,string method,string product)
        {
            var webRequest = (HttpWebRequest) WebRequest.Create(uri);
            webRequest.Method = method;
            webRequest.ContentType = "application/json";
            if(method == "POST" || method == "PUT")
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(product);

                using(var requestStream = webRequest.GetRequestStream())
                using(var streamWriter = new StreamWriter(requestStream))
                {
                    requestStream.Write(dataBytes,0,dataBytes.Length);
                    streamWriter.Flush();
                }
            }


            var webResponse = (HttpWebResponse) webRequest.GetResponse();

            using(var reader = new StreamReader(webResponse.GetResponseStream()))
            {
                string response = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<JObject>(response);
            }
        }

        private string retrieveMethod;
        private int retrieveID;
        private string retrieveName;
        private string retrieveUnitsInStock;
        private string retrieveUnitPrice;

        public void RetrieveMethod(string method)
        {
            this.retrieveMethod = method;
        }
        public void RetrieveID(int id)
        {
            this.retrieveID = id;
        }

        public void RetrieveProduct(API.Models.Product product)
        {
            this.retrieveName = product.ProductName;
            this.retrieveUnitPrice = product.UnitPrice.ToString();
            this.retrieveUnitsInStock = product.UnitsInStock.ToString();
        }

        private void Form2_Load(object sender,EventArgs e)
        {
            txt_ProductName.Text = retrieveName;
            txt_UnitPrice.Text = retrieveUnitPrice;
            txt_UnitsInStock.Text = retrieveUnitsInStock;
        }

        internal void RetrieveID(object value)
        {
            throw new NotImplementedException();
        }
    }


}
