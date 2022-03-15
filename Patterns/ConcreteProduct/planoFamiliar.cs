namespace factory
{
    public class planoFamiliar : planoSaudeProduct
    {

        private string _tipoPlano;
        private int _qutPessoas;
        private int _qutMaioresTrintaAnos;

        public planoFamiliar(string tipoPlano, int qutPessoas, int qutMaioresTrintaAnos)
        {
            this._tipoPlano = tipoPlano;
            this._qutPessoas = qutPessoas;
            this._qutMaioresTrintaAnos = qutMaioresTrintaAnos;
        }

        public override double retornarValorPlano() {
            return 200.00;
        }

        public override string descricaoPlano() {
            return "Plano para uma familia.";
        }

        public override bool podeFazerPlano() {
            return (_qutPessoas > 1 && _qutMaioresTrintaAnos <= 2);
        }
    }
}