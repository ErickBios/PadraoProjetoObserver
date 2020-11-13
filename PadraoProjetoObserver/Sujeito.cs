namespace PadraoProjetoObserver
{
    interface Sujeito
    {
        void RegistrarObservador(Observador o);
        void RemoverObservador(Observador o);
        void NotificarObservadores();
    }
}
