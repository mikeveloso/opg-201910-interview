using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opg_201910_interview.Models
{
    public class Client
    {

        public Client()
        {
            ClientFiles = new List<ClientFile>();
        }

        public int ClientId { get; set; }

        public string ClientName { get; set; }

        public List<ClientFile> ClientFiles { get; set; }

        public override bool Equals(object obj)
        {
            var client = (Client)obj;
            
            try
            {
                if (this.ClientId == client.ClientId && this.ClientName == client.ClientName && this.ClientFiles.Count == client.ClientFiles.Count)
                {
                    for (int i = 0; i < this.ClientFiles.Count; i++)
                    {
                        if (!this.ClientFiles[i].Equals(client.ClientFiles[i]))
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
