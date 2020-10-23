using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGasto
{
    class conexaoSGBD
    {
        string sQLiteConnection;
        SQLiteConnection conn = null;

        public bool conexao()
        {
            try
            {
                string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string localDataBase = BaseDirectory.Replace("\\bin\\Debug\\", "\\SGBD_Sqlite\\ControleDeGastos.db3");
                
                sQLiteConnection = $"Data Source={localDataBase}";
                conn = new SQLiteConnection(sQLiteConnection);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void conectar()
        {
            conn.Open();
        }
        public void desconectar()
        {
            conn.Close();
        }

        public SQLiteDataAdapter DataAdapter(string inSQL)
        {
            SQLiteDataAdapter da = null;
            if (conexao())
                da = new SQLiteDataAdapter(inSQL, sQLiteConnection);
            desconectar();
            return da;
        }

        public bool inserDivida(string dtInicio, int qtdParcela, string vlrParcela, string descricao, int id_usuario)
        {
            if (conexao())
            {
                var inSQL = $"insert into TB_DIVIDAS (DATAINICIO, QTDPARCELA, VALORTOTAL, DESCRICAO, ID_LOGIN) " +
                    $"VALUES('{dtInicio}', {qtdParcela},round(({vlrParcela} * {qtdParcela}),2),'{descricao}', {id_usuario})";

                conectar();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = inSQL;
                    cmd.Prepare();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return true;
        }

        public bool excluirDivida(List<int> id_parcelas)
        {
            string lista_id = "";
            foreach (var id in id_parcelas)
                lista_id += " " + id;
            lista_id = lista_id.Trim().Replace(" ", ",");

            if (conexao())
            {
                var inSQL = "delete from TB_PARCELAS where ID_DIVIDA in (" +
                    " select case count(todosIDs.IdAExcluir)" +
                    "           when 0 then 0 " +
                    "           else todosIDs.IdAExcluir " +
                    "       end ListaExcluidos " +
                    $"from(SELECT ID_DIVIDA as IdAExcluir FROM TB_PARCELAS tp where tp.ID in ({lista_id})) as todosIDs, " +
                    "     (select case count(tp.ID_DIVIDA) " +
                    "                 when 0 then 0 " +
                    "                 else tp.ID_DIVIDA " +
                    "            end IdsAExcluir " +
                    "      from TB_PARCELAS tp " +
                    $"      where tp.ID_DIVIDA in (select tp.ID_DIVIDA from TB_PARCELAS tp where tp.ID in ({lista_id})) " +
                    "      and tp.STATUS_PAGO = 1 ) as idDividasPagas " +
                    "where todosIDs.IdAExcluir != idDividasPagas.IdsAExcluir);" +
                    "                delete from TB_DIVIDAS where ID in ( " +
                    "                select case count(todosIDs.IdAExcluir) " +
                    "           when 0 then 0 " +
                    "           else todosIDs.IdAExcluir" +
                    "       end ListaExcluidos " +
                    $" from(SELECT ID_DIVIDA as IdAExcluir FROM TB_PARCELAS tp where tp.ID in ({lista_id})) as todosIDs," +
                    "     (select case count(tp.ID_DIVIDA) " +
                    "                 when 0 then 0" +
                    "                 else tp.ID_DIVIDA" +
                    "            end IdsAExcluir" +
                    "      from TB_PARCELAS tp" +
                    $"      where tp.ID_DIVIDA in (select tp.ID_DIVIDA from TB_PARCELAS tp where tp.ID in ({lista_id}))" +
                    "      and tp.STATUS_PAGO = 1 ) as idDividasPagas" +
                    " where todosIDs.IdAExcluir != idDividasPagas.IdsAExcluir); ";

                conectar();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = inSQL;
                    cmd.Prepare();
                    try
                    {
                        var i = cmd.ExecuteNonQuery();                        
                        if(i > 0)
                            return true;
                        else
                            return false;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return true;
        }

        public bool excluirEntrada(List<int> id_entradas)
        {
            string lista_id = "";
            foreach (var id in id_entradas)
                lista_id += " " + id;
            lista_id = lista_id.Trim().Replace(" ", ",");

            if (conexao())
            {
                var inSQL = "DELETE FROM TB_ENTRADA_VALORES " +
                    $"WHERE ID in ({lista_id})";

                conectar();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = inSQL;
                    cmd.Prepare();
                    try
                    {

                        var i = cmd.ExecuteNonQuery();

                        if (i > 0)
                            return true;
                        else
                            return false;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return true;
        }

        public bool insertParcela(string dataVenciamento, int NRPARCELA, string VLRPARCELA, int id_divida)
        {
            if (conexao())
            {
                var inSQL = $"insert into TB_PARCELAS (ID_DIVIDA, NRPARCELA, VALORPARCELA, DATAVENC) " +
                    $"VALUES({id_divida}, {NRPARCELA}, {VLRPARCELA}, '{dataVenciamento}')";

                conectar();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = inSQL;
                    cmd.Prepare();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return true;
        }

        public bool insertEntrada(string vlrEntrada, string descricaoEntrada, string dataEntrada, int id_usuario)
        {
            try
            {
                if (conexao())
                {
                    var inSQL = $"INSERT INTO TB_ENTRADA_VALORES (VALOR_ENTRADA, DESCRICAO_ENTRADA, DATA_ENTRADA, ID_LOGIN) " +
                        $"VALUES ( '{vlrEntrada}', '{descricaoEntrada}', '{dataEntrada}', {id_usuario});";

                    conectar();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = inSQL;
                        cmd.Prepare();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertUsuario(string usuario, string senha)
        {
            try
            {
                if (conexao())
                {
                    var inSQL = "INSERT INTO TB_LOGIN (USUARIO, SENHA) " +
                        $"VALUES ('{usuario}', '{senha}');";

                    conectar();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = inSQL;
                        cmd.Prepare();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateDivida(List<int> id_parcelas, bool dividaAtiva)
        {
            string inSQL = string.Empty;
            string lista_id = "";
            if (conexao())
            {
                foreach (var id in id_parcelas)
                    lista_id += " " + id;
                lista_id = lista_id.Trim().Replace(" ", ",");

                if(dividaAtiva)
                    inSQL = $"update TB_PARCELAS set STATUS_PAGO = 1 where ID in ({lista_id})";
                else
                    inSQL = $"update TB_PARCELAS set STATUS_PAGO = 0 where ID in ({lista_id})";

                conectar();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = inSQL;
                    cmd.Prepare();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return true;
        }
        
        public bool calculoSaldo(string mesAno)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string ConvNumber(string value)
        {
            NumberStyles style;
            CultureInfo culture;
            double number;
            int aux = 0;

            foreach (var item in value)
            {
                if (item == ',')
                    aux++;
            }
            if (aux == 1 && value.Length < 8)
                return value.Replace(",",".");

            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("pt-BR");
            if (Double.TryParse(value, style, culture, out number))
                value = number.ToString().Replace(",",".");

            return value;
        }
    }
}
