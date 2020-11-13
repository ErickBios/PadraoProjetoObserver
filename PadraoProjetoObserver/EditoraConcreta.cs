using System;
using System.Collections.Generic;

namespace PadraoProjetoObserver
{
    class EditoraConcreta : Sujeito
    {
        private List<Observador> observadores = new List<Observador>();
        private bool _novaEdicao = false;

        public void RegistrarObservador(Observador o)
        {
            observadores.Add(o);
        }

        public void RemoverObservador(Observador o)
        {
            observadores.Remove(o);
        }

        public void NotificarObservadores()
        {
            foreach (Observador o in observadores)
            {
                o.Atualizar(this);
            }
        }

        public void alterarEdicao()
        {
            if (_novaEdicao)
                _novaEdicao = false;
            else
                _novaEdicao = true;
            NotificarObservadores();
        }

        public Boolean getEdicao()
        {
            return _novaEdicao;
        }
    }
}
