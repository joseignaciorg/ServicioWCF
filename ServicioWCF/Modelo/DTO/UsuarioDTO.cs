using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServicioWCF.Modelo.DTO
{
    [DataContract]
    public class UsuarioDTO
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string apellidos { get; set; }

        public Usuario ToBasedeDatos()
        {
            var usu = new Usuario()
            {
                id = id,
                nombre = nombre,
                apellidos = apellidos
            };

            return usu;
        }

        public static UsuarioDTO FromBasedeDatos(Usuario usu)
        {
            var usuDTO=new UsuarioDTO();
            usuDTO.nombre = usu.nombre;
            usuDTO.apellidos = usu.apellidos;
            usuDTO.id = usu.id;
            return usuDTO;

        }

        public static List<UsuarioDTO> FromListUsuario(List<Usuario> Lista )
        {
            var l =new List<UsuarioDTO>();

            foreach (var item in Lista)
            {
                l.Add(UsuarioDTO.FromBasedeDatos(item));   
            }
            return l;
        } 
    }
}