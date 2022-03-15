namespace factory
{
    public class planoIndividual : planoSaudeProduct
    {

        private string _tipoPlano;
        private int _qutPessoas;
        private int _qutMaioresTrintaAnos;

        public planoIndividual(string tipoPlano, int qutPessoas, int qutMaioresTrintaAnos)
        {
            this._tipoPlano = tipoPlano;
            this._qutPessoas = qutPessoas;
            this._qutMaioresTrintaAnos = qutMaioresTrintaAnos;
        }

        public override double retornarValorPlano() {
            return 100.00;
        }

        public override string descricaoPlano() {
            return "Plano para uma unica pessoa.";
        }

        public override bool podeFazerPlano() {
            return (_qutMaioresTrintaAnos == 0);
        }
    }
}