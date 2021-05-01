using System.Collections.Generic;

namespace DatabaseDevelopment.Models
{
    public class ConnectionString
    {
        public string ConnString { get; set; }
        public User User { get; set; }
        public IEnumerable<string> Tables { get; set; }
    }
}