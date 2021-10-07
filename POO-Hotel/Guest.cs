//Frederico Guilherme Camilli Proença RA:200925
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Hotel
{
    class Guest
    {
        //Declaração das auto properties Name e Email.
        public string Name { get; set; }
        public string Email { get; set; }

        //Declaração do construtor Guest, que possui como parametros as variáveis name e email, que se baseiam nas autoproperties já declaradas.
        public Guest(string name, string email)
        {
            Name = name;
            Email = email;
        }

        //Superclasse que será retornada no programa principal, retornando o Name e Email.
        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
