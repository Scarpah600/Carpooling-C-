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
    
    public partial class USUARIOS
    {
        public USUARIOS()
        {
            this.AGENDA = new HashSet<AGENDA>();
            this.VEICULO = new HashSet<VEICULO>();
        }
    
        public int ID { get; set; }
        public string NOME { get; set; }
        public string EMAIL { get; set; }
        public string RG { get; set; }
        public string ENDERECO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string CEP { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string TELEFONE { get; set; }
        public string CELULAR { get; set; }
        public string USUARIOSISTEMA { get; set; }
    
        public virtual ICollection<AGENDA> AGENDA { get; set; }
        public virtual ICollection<VEICULO> VEICULO { get; set; }
    }
}
