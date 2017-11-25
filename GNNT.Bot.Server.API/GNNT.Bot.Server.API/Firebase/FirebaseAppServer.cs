using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GNNT.Bot.Server.API.Firebase
{
    public class FirebaseAppServer
    {
        //public async static Task accessFirebase()
        //{
        //    String serviceAccountEmail = "serviceaccount1@myapp.iam.gserviceaccount.com";

        //    var certificate = new X509Certificate2(@"App.p12", "notasecret", X509KeyStorageFlags.Exportable); //App2 is the certificate i downloaded from API console

        //    ServiceAccountCredential credential = new ServiceAccountCredential(
        //       new ServiceAccountCredential.Initializer(serviceAccountEmail)
        //       {
        //           Scopes = new[] { "https://www.googleapis.com/auth/firebase.database" //from https://developers.google.com/identity/protocols/googlescopes
        //                            ,"https://www.googleapis.com/auth/firebase"
        //                            ,"https://www.googleapis.com/auth/cloud-platform"}
        //       }.FromCertificate(certificate));


        //    var task = await credential.RequestAccessTokenAsync(System.Threading.CancellationToken.None);

        //    Console.WriteLine("AccessToken " + credential.Token.AccessToken); //accessToken has a value, so guess is all good so far.

        //    var request = (HttpWebRequest)WebRequest.Create("https://<Myapp>.firebaseio.com/.json?access_token=" + credential.Token.AccessToken);
        //    request.Method = "GET";
        //    request.ContentType = "application/json";

        //    using (var response = (HttpWebResponse)request.GetResponse()) //Throw error 403 - forbidden
        //    {
        //        var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        //        Console.WriteLine("responseString " + responseString);
        //    }
        //}
    }
}