namespace factory
{
    public class planoEmpresarial : planoSaudeProduct
    {

        private string _tipoPlano;
        private int _qutPessoas;
        private int _qutMaioresTrintaAnos;

        public planoEmpresarial(string tipoPlano, int qutPessoas, int qutMaioresTrintaAnos)
        {
            this._tipoPlano = tipoPlano;
            this._qutPessoas = qutPessoas;
            this._qutMaioresTrintaAnos = qutMaioresTrintaAnos;
        }

        public override double retornarValorPlano() {
            return 300.00;
        }

        public override string descricaoPlano() {
            return "Plano para uma empresa que tenha mais de 100 funcionarios.";
        }

        public override bool podeFazerPlano() {
            return (_qutPessoas > 100) ;
        }
    }
}