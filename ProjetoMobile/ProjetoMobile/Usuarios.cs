using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile
{
    class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public Guid ID { get; set; }

        [MaxLength(50), NotNull]
        public string Nome { get; set; }

        [MaxLength(100), NotNull]
        public string Endereco { get; set; }

        [MaxLength(255), NotNull]
        public string Email { get; set; }

        [MaxLength(255), NotNull]
        public string Senha { get; set; }

        [MaxLength(255), NotNull]
        public string Senha2 { get; set; }

        [MaxLength(11), NotNull]
        public string Telefone { get; set; }


    }
}
