namespace CRUD_API.Model
{
    public class Contato(int id, string nome, string telefone, string email, bool ativo)
    {
        public int Id { get; private set; } = id;
        public string Nome { get; private set; } = nome;
        public string Telefone { get; private set; } = telefone;
        public string Email { get; private set; } = email;
        public bool Ativo { get; private set; } = ativo;

        public void Update(string nome, string email, string telefone, bool ativo)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Ativo = ativo;
        }
    }
}
