//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Carpooling.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DESTINO
    {
        public DESTINO()
        {
            this.AGENDA = new HashSet<AGENDA>();
        }
    
        public int ID { get; set; }
        public string ENDERECO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string CEP { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string TELEFONE { get; set; }
    
        public virtual ICollection<AGENDA> AGENDA { get; set; }
    }
}