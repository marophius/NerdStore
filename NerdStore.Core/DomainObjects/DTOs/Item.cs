using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.DomainObjects.DTOs
{
    public class Item
    {
        public Guid Id { get; set; }
        public int Quantidade { get; set; }
    }
}
