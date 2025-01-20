using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QueVistoHoje.RCL.Data.Entities;

namespace QueVistoHoje.RCL.Data {
    public class UserService {
        public string Nome { get; set; } = string.Empty;
<<<<<<< HEAD
        public string Email {  get; set; } = string.Empty;
=======
>>>>>>> 817da96e6c7472d81c14db231778c170d33ecb80
        public string Token { get; set; } = string.Empty;
        public List<Produto> Carrinho { get; set; } = new List<Produto>();

        public event Action? UserChanged;

        public void SetUserData(string email, string token) {
<<<<<<< HEAD
            Email = email;
=======
>>>>>>> 817da96e6c7472d81c14db231778c170d33ecb80
            Nome = email.Split('@')[0];
            Token = token;
            UserChanged?.Invoke(); 
        }

        public void ClearUserData() {
            Nome = string.Empty;
            Token = string.Empty;
            UserChanged?.Invoke(); 
        }

        public void AddToCarrinho(Produto produto) {
            Carrinho.Add(produto);
        }

        public void ClearCarrinho() {
            Carrinho.Clear();
        }
    }
}
