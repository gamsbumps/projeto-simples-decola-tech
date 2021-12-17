using DIO.Curtas.Interface;

namespace DIO.Curtas.Classes
{
    public class CurtasRepositorio : IRepositorio<Curtas>
    {
        private List<Curtas> listaCurtas = new List<Curtas>();
        public void Atualiza(int id, Curtas objeto)
        {
            listaCurtas[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaCurtas[id].Excluir();
        }

        public void Insere(Curtas objeto)
        {
            listaCurtas.Add(objeto);
        }

        public List<Curtas> Lista()
        {
            return listaCurtas;
        }

        public int ProximoId()
        {
            return listaCurtas.Count;
        }

        public Curtas RetornaPorId(int id)
        {
            return listaCurtas[id];
        }
    }
}