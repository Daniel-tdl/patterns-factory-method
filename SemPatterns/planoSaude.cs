namespace factory.SemPatterns
{
    public class planoSaude
    {
        private string _tipoPlano;
        private int _qutPessoas;
        private int _qutMaioresTrintaAnos;

        public planoSaude(string tipoPlano, int qutPessoas, int qutMaioresTrintaAnos)
        {
            this._tipoPlano = tipoPlano;
            this._qutPessoas = qutPessoas;
            this._qutMaioresTrintaAnos = qutMaioresTrintaAnos;
        }

        public double retornarValorPlano() {
            if (_tipoPlano == "PLANO_INDIVIDUAL") {
                return 100.00;
            } if (_tipoPlano == "PLANO_FAMILIAR") {
                return 200.00;
            } if (_tipoPlano == "PLANO_EMPRESARIAL") {
                return 300.00;
            } else {
                return 5000.00;
            }
        }

        public string descricaoPlano() {
            if (_tipoPlano == "PLANO_INDIVIDUAL") {
                return "Plano para uma unica pessoa.";
            } if (_tipoPlano == "PLANO_FAMILIAR") {
                return "Plano para uma familia.";
            } if (_tipoPlano == "PLANO_EMPRESARIAL") {
                return "Plano para uma empresa que tenha mais de 100 funcionarios.";
            } else {
                return "Plano empresarial master para empresa que tenha mais de 1000 funcionarios .";
            }
        }


        public bool podeFazerPlano() {
            if (_tipoPlano == "PLANO_INDIVIDUAL") {
                return regrasPlanoIndividual();
            } if (_tipoPlano == "PLANO_FAMILIAR") {
                return regrasPlanoFamiliar();
            } if (_tipoPlano == "PLANO_EMPRESARIAL") {
                return regrasPlanoEmpresarial();
            } else {
                return regrasPlanoMaster();
            }
        }

        private bool regrasPlanoIndividual() {
            return (_qutMaioresTrintaAnos == 0);
        }

        private bool regrasPlanoFamiliar() {
            return (_qutPessoas > 1 && _qutMaioresTrintaAnos <= 2);
        }

        private bool regrasPlanoEmpresarial() {
            return (_qutPessoas > 100) ;
        }

        private bool regrasPlanoMaster() {
            return _qutPessoas > 1000;
        }

    }
}