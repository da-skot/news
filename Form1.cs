using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml;
using System.Data.Common;

namespace laba_7_8
{
    public partial class Form1 : Form
    {
        public SQLiteConnection db;
        SQLiteCommand command;
        public XmlDocument xmlNews;
        public Form1()
        {
            InitializeComponent();
            db = new SQLiteConnection("Data Source = database.db");
            db.Open();
            command = new SQLiteCommand("PRAGMA synchronous = 1; CREATE TABLE IF NOT EXISTS News (Id INTEGER PRIMARY KEY AUTOINCREMENT, Title, Link, Description, PubDate);", db);
            command.ExecuteNonQuery();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Close();
            db.Dispose();
        }
        private void DownloadRSS_Click(object sender, EventArgs e)
        {
            xmlNews = new XmlDocument();
            try
            {
                xmlNews.Load(textBox1.Text);
                webBrowser1.Navigate(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Некоректный URL");
            }
        }

        private void UploadDB_Click(object sender, EventArgs e)
        {
            command = new SQLiteCommand("DELETE FROM News", db);
            command.ExecuteNonQuery();
            try
            {
                XmlNodeList childNodeList = xmlNews.DocumentElement.SelectSingleNode("channel").SelectNodes("item");
                foreach (XmlNode xmlNode in childNodeList)
                {
                    command = new SQLiteCommand("INSERT INTO News(Title,Link,Description,PubDate)VALUES(@title, @link, @description, @pubDate)", db);
                    command.Parameters.AddWithValue("@title", xmlNode.SelectSingleNode("title").InnerText);
                    command.Parameters.AddWithValue("@link", xmlNode.SelectSingleNode("link").InnerText);
                    command.Parameters.AddWithValue("@description", xmlNode.SelectSingleNode("description").InnerText);
                    command.Parameters.AddWithValue("@pubDate", xmlNode.SelectSingleNode("pubDate").InnerText);
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show("XML-документ пуст. Загрузите RSS");
            }

        }
        struct MyNews
        {
            public string PubDate;
            public string Title;
            public string Link;
            public string Description;
        }
        List<MyNews> News = new List<MyNews>();
        private void DownloadBD_Click(object sender, EventArgs e)
        {
            News.Clear();
            MyNews news = new MyNews();
            richTextBox1.Text = "";
            command = new SQLiteCommand("SELECT * FROM News", db);
            SQLiteDataReader reader = command.ExecuteReader();
            foreach (DbDataRecord item in reader) 
            {
                news.Title = item["Title"].ToString();
                news.PubDate = item["PubDate"].ToString();
                news.Link = item["Link"].ToString();
                news.Description = item["Description"].ToString();
                richTextBox1.AppendText(new string('=', 70) + "\n");
                richTextBox1.AppendText(news.PubDate + "\n");
                richTextBox1.AppendText(news.Title + "\n");
                richTextBox1.AppendText(news.Link + "\n");
                richTextBox1.AppendText(news.Description + "\n");
                richTextBox1.AppendText(new string('=', 70) + "\n");
                News.Add(news);                  
            }
            MessageBox.Show("База данных выгружена. Новостей:"+News.Count);           
        }
    }
}
