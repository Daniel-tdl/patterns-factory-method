namespace factory
{
    public class planoMaster : planoSaudeProduct
    {

        private string _tipoPlano;
        private int _qutPessoas;
        private int _qutMaioresTrintaAnos;

        public planoMaster(string tipoPlano, int qutPessoas, int qutMaioresTrintaAnos)
        {
            this._tipoPlano = tipoPlano;
            this._qutPessoas = qutPessoas;
            this._qutMaioresTrintaAnos = qutMaioresTrintaAnos;
        }

        public override double retornarValorPlano() {
            return 5000.00;
        }

        public override string descricaoPlano() {
            return "Plano empresarial master para empresa que tenha mais de 1000 funcionarios .";
        }

        public override bool podeFazerPlano() {
            return _qutPessoas > 1000;
        }
    }
}