namespace construtores.models
{
    // Design Pattern => Singleton
    public class Log
    {
        private static Log? _log;

        // Construtor privado para garantir que esse objeto não possa ser instanciado por outra classe
        private Log() { }

        public static Log GetInstance() {
            if(_log == null) {
                _log = new Log();
            }
            return _log;
        }
    }
}