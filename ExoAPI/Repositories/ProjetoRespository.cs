using ExoAPI.Contexts;
using ExoAPI.Domains;

namespace ExoAPI.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoApiContext _ctx;

        public ProjetoRepository(ExoApiContext ctx)
        {
            _ctx = ctx;
        }

        public List<Projeto> Listar()
        {
            return _ctx.Projetos.ToList();
        }

        public void Criar(Projeto projeto)
        {
            _ctx.Projetos.Add(projeto);
            _ctx.SaveChanges();
        }

        public void Atualizar(int id, Projeto projeto)
        {
            Projeto projetoBuscado = _ctx.Projetos.Find(id);

            if (projeto.NomeDoProjeto != null)
            {
                projetoBuscado.NomeDoProjeto = projeto.NomeDoProjeto;
            }

            if (projeto.Area != null)
            {
                projetoBuscado.Area = projeto.Area;
            }

            if (projeto.Status != null)
            {
                projetoBuscado.Status = projeto.Status;
            }

            _ctx.Projetos.Update(projetoBuscado);
            _ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Projeto projeto = _ctx.Projetos.Find(id);
            _ctx.Remove(projeto);
            _ctx.SaveChanges();
        }
    }
}
