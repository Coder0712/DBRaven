using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;
using Raven.Client.Exceptions;
using Raven.Client.Extensions;
using Raven.Client.Http;
using Raven.Client.Json;
using Raven.Client.Properties;
using Raven.Client.ServerWide;
using Raven.Client.Util;
using Raven.Client.Json.Serialization.NewtonsoftJson;
using Raven.Client.Documents.Session.Operations;
using Raven.Client.Documents.Commands;
using Raven.Client.Documents.Queries;
using Raven.Client.ServerWide.Commands;
using Raven.Client.Documents.Conventions;
using Raven.Client.Documents.Attachments;
using Raven.Client.Documents.BulkInsert;
using Sparrow.Documentation.Xml;



namespace DBRaven
{
    public class DBRavenClient
    {
       public void Connection()
        {
            IDocumentStore store;

            store = new DocumentStore()
            {
                Urls = new[]
                {
                    "http://127.0.0.1:8080"
                },
            }.Initialize();

            SessionOptions sOption = new SessionOptions
            {
                Database = "Mails"
            };

            using (IDocumentSession Session = store.OpenSession(sOption))
            {
                Mail mail = new Mail
                {
                    From = "test@test.de",
                    To = "buh@test.de"
                };

                DocumentInfo info = new DocumentInfo
                {
                    Collection = "Mails"
                };

               

             }


            

        }
    }
}
