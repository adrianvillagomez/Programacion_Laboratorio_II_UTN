using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SobreSobreescrito : Sobreescrito
    {
        public SobreSobreescrito():base()
        {          
        }
        public override string MiMetodo()
        {
            return base.miAtributo;
        }
        protected override string MiPropiedad
        {
            get
            {
                return MiMetodo();
            }
        }
        
    }
}
