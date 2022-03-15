namespace factory
{
    public class planoSaudeFactory : planoSaudeCreator
    {
        private string _tipoPlano;
        private int _qutPessoas;
        private int _qutMaioresTrintaAnos;

        public planoSaudeFactory(string tipoPlano, int qutPessoas, int qutMaioresTrintaAnos)
        {
            this._tipoPlano = tipoPlano;
            this._qutPessoas = qutPessoas;
            this._qutMaioresTrintaAnos = qutMaioresTrintaAnos;
        }

        public override planoSaudeProduct BuscarPlanoSaude() {
            switch(_tipoPlano) {
                case "PLANO_INDIVIDUAL" : return new planoIndividual(_tipoPlano, _qutPessoas, _qutMaioresTrintaAnos);
                case "PLANO_FAMILIAR" : return new planoFamiliar(_tipoPlano, _qutPessoas, _qutMaioresTrintaAnos);
                case "PLANO_EMPRESARIAL" : return new planoFamiliar(_tipoPlano, _qutPessoas, _qutMaioresTrintaAnos);
                default : return new planoMaster(_tipoPlano, _qutPessoas, _qutMaioresTrintaAnos);
            }
        }
    }
}