using GestorSAAE.DAO;
using GestorSAAE.Entidades;
using System.Collections.Generic;

namespace GestorSAAE.Model
{
    public class FuncionarioModel
    {
        /// <summary>
        /// Método que Insere um novo funcionário de acordo com os dados informados.
        /// </summary>
        /// <param name="objTabela"> Dados do funcionário</param>
        /// <returns> True para inserção bem sucedida e False para problemas na inserção. </returns>
        public static bool Inserir(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Inserir(objTabela);
        }

        /// <summary>
        /// Método que Lista os funcionários do banco de dados.
        /// </summary>
        /// <returns> List de funcionários cadastrados.</returns>
        public List<FuncionarioEnt> Lista()
        {
            return new FuncionarioDAO().Lista();
        }

        /// <summary>
        /// Método que Loga os funcionários no sistema.
        /// </summary>
        /// <param name="objTabela"> Dados do Login.</param>
        /// <returns> Dados do login do Funcionário.</returns>
        public FuncionarioEnt Login(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Login(objTabela);
        }

        /// <summary>
        /// Método que Lista os dados dos funcionários de acordo o campo informado.
        /// </summary>
        /// <param name="campo"> Nome do campo a ser pesquisado.</param>
        /// <param name="objTabela"> Dados da pesquisa.</param>
        /// <returns> List de funcinários pesquisados.</returns>
        public List<FuncionarioEnt> Lista(string campo, FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Lista(campo, objTabela);
        }

        /// <summary>
        /// Método que Exibe os dados do funcionário pesquisado.
        /// </summary>
        /// <param name="objTabela"> Dados da pesquisa.</param>
        /// <returns> List dos dados do funcionário.</returns>
        public List<FuncionarioEnt> Exibir(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Exibe(objTabela);
        }

        /// <summary>
        /// Método que Exclui um funcionário.
        /// </summary>
        /// <param name="objTabela"> Dados do funcionário a ser excluído.</param>
        /// <returns> True para exclusão bem sucedida e False para exclusão não realizada.</returns>
        public static bool Excluir(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Excluir(objTabela);
        }

        /// <summary>
        /// Método que Edita um funcionário.
        /// </summary>
        /// <param name="objTabela"> Novos dados do funcionário.</param>
        /// <param name="altSenha"> Campo que define se a edição vai atualizar a senha ou não. True para atualizar senha e false para não atualizar a senha.</param>
        /// <returns> True para atualização bem sucedidad e False para atualização não realizada.</returns>
        public static bool Editar(FuncionarioEnt objTabela, bool altSenha)
        {
            return new FuncionarioDAO().Editar(objTabela, altSenha);
        }

        /// <summary>
        /// Método que Gera um Contato do funcionário no formato QRCode
        /// </summary>
        /// <param name="objTabela"> Dados do contato do funcionário</param>
        /// <returns> Image QRCode do contato do funcionário.</returns>
        public static bool GerarQr(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().GerarQr(objTabela);
        }
    }
}
