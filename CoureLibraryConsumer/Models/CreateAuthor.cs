using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureLibraryConsumer.Models
{

    public class CreateAuthor
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string mainCategory { get; set; }

        public DateTime dateOfBirth { get; set; }
    }
}
