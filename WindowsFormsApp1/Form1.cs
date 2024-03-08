using API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly static string baseURL = "https://localhost:7237/api/products/";
        private void button1_Click(object sender,EventArgs e)    // LIST & GET BUTTON
        {
            //client.BaseAddress = new Uri("https://localhost:7237/");
            //HttpResponseMessage response = client.GetAsync("api/products").Result;

            if(string.IsNullOrEmpty(textBox1.Text))
            {
                dataGridView1.DataSource = GetRESTData(baseURL);
            }           
                //dataGridView1.DataSource = GetRESTData(baseURL + textBox1.Text);


        }
        private void button3_Click(object sender,EventArgs e)     // ADD BUTTON
        {
            Form2 form2 = new Form2();
            form2.RetrieveMethod("POST");
            form2.Show();
        }

        private void button2_Click(object sender,EventArgs e)      // DELETE
        {
            DeleteRESTData(baseURL + textBox1.Text);
            MessageBox.Show("Product was deleted successfully.");
            dataGridView1.DataSource= GetRESTData(baseURL);
        }

        private void button1_Click_1(object sender,EventArgs e)    // UPDATE 
        {
            Form2 form2 = new Form2();
            form2.RetrieveMethod("PUT");
            form2.RetrieveID(System.Int32.Parse(textBox1.Text));
            var product = GetRESTProduct(baseURL + textBox1.Text);
            Product result = JsonConvert.DeserializeObject<Product>(product.ToString());
            form2.RetrieveProduct(result);
            form2.Show();
        }


        private JArray GetRESTData(string uri)
        {
            var webRequest = (HttpWebRequest) WebRequest.Create(uri);
            var webResponse = (HttpWebResponse) webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);

        }

        private JObject GetRESTProduct(string uri)
        {
            var webRequest = (HttpWebRequest) WebRequest.Create(uri);
            var webResponse = (HttpWebResponse) webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JObject>(s);

        }

        private void DeleteRESTData(string uri)
        {
            var webRequest = (HttpWebRequest) WebRequest.Create(uri);
            webRequest.Method = "DELETE";

            //using(var webResponse = (HttpWebResponse) webRequest.GetResponse())
            //{

            //}    
            var webResponse = (HttpWebResponse) webRequest.GetResponse();
        }


    }
}
