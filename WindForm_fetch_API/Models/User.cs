using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindForm_fetch_API.Models
{
    public class User
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("name")] public string Name{ get; set; }
        [JsonProperty("saldo")] public Int128 Saldo { get; set; }
        [JsonProperty("hutang")] public Int128 Hutang { get; set; }
        [JsonProperty("NetWorth")] public Int128 NetWorth { get; set; }

    }
}
