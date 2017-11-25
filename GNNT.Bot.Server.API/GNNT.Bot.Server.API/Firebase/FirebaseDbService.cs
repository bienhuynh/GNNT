using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace GNNT.Bot.Server.API.Firebase
{
    public class FirebaseDbService
    {
        public void POSTWriteRecord(string json, string requestURLString)
        {
            var request = WebRequest.CreateHttp(requestURLString);
            request.Method = "POST";
            request.ContentType = "application/json";
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();
        }
    }
}