using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class ClassSqlConnect
    {
        private SqlConnection connect;
        private string[] sqlBuffer;
        public ClassSqlConnect()//构造方法，初始化sql连接
        {
            connect = new SqlConnection();
            connect.ConnectionString = "server=.;database=EIMS;user=sa;pwd=123456";
            connect.Open();//建立与EIMS数据库的连接
        }
        
        void Substring(string sql)//循环划分信息
        {
            int i = 4;//规定各种窗体传递的信息是以四个字符的关键字段XXXX开始
            int j = 0;//以','号作分隔符，' '作结尾符的字符串格式数据。
            while(sql[i]!=' ')
            {
                while (sql[i] != ',' && sql[i] != ' ')
                {
                    sqlBuffer[j] +=sql[i];
                    i++;
                }
                if (sql[i] != ' ')
                {
                    i++;
                    j++;
                }
            }
        }
        public void Update(string sqlCommand)//自定义Update方法，主要用于构成并执行T-SQL语言的UPDATE语句
        {
            string table = sqlCommand.Substring(0, 4);//前四个字符作为判断操作表的依据
            SqlCommand cmd;
            switch (table)//根据要操作的表的数据结构构造SQL语句
            {
                case "USER":
                    //BUGBUGBUGBUG
                    sqlBuffer = new string[4];//根据相应窗体划分SQL语句缓冲区
                    Substring(sqlCommand);//划分各模块传递的信息
                    cmd = connect.CreateCommand();
                    cmd.CommandText = string.Format("UPDATE USERS SET UName = '" + sqlBuffer[1]  + "',UPower = " + sqlBuffer[2] +",Password = '" + sqlBuffer[3]+ "'WHERE UID = '"
                   + sqlBuffer[0] + "'");//构成SQL语句
                    cmd.ExecuteNonQuery();//执行SQL语句
                    break;
                case "STAF":
                    sqlBuffer = new string[10];
                    Substring(sqlCommand);
                    cmd = connect.CreateCommand();
                    cmd.CommandText = string.Format("UPDATE STAFF SET SName = '" + sqlBuffer[1]  + "',SAge = " + sqlBuffer[2] +",SSex = '" + sqlBuffer[3]+
                        "',SAddress = '" + sqlBuffer[4]+"',STel = '" + sqlBuffer[5]+"',SSchool = '" + sqlBuffer[6]+"',SDept = '" + sqlBuffer[7]+"',SPosition = '" 
                        + sqlBuffer[8]+"',SSalary = " + sqlBuffer[9] + "WHERE SID = '" + sqlBuffer[0] + "'");
                    cmd.ExecuteNonQuery();
                    break;
                case "INST":
                    sqlBuffer = new string[5];
                    Substring(sqlCommand);
                    cmd = connect.CreateCommand();
                    cmd.CommandText = string.Format("UPDATE INSTORE SET PName = '" + sqlBuffer[1]  +"',PNumber = " + sqlBuffer[2]+
                        ",IPrice = " + sqlBuffer[4] + " WHERE PID = '" + sqlBuffer[0] + "'AND InTime = '" + sqlBuffer[3]+"'");
                    cmd.ExecuteNonQuery();
                    break;
                case "OUST":
                    sqlBuffer = new string[4];
                    Substring(sqlCommand);
                    cmd = connect.CreateCommand();
                    cmd.CommandText = string.Format("UPDATE OUTSTORE SET PName = '" + sqlBuffer[1]  + "',PNumber = " + sqlBuffer[2] + "WHERE PID = '" + sqlBuffer[0]
                        + "'AND OutTime = '" + sqlBuffer[3]+"'");
                    cmd.ExecuteNonQuery();
                    break;
                case "SALE":
                    sqlBuffer = new string[7];
                    Substring(sqlCommand);
                    cmd = connect.CreateCommand();
                    cmd.CommandText = string.Format("UPDATE SALE SET PName = '" + sqlBuffer[1] +"',PNumber = " + sqlBuffer[2]+
                        ",SPrice = " + sqlBuffer[3] + ",SaleStaffName = '" + sqlBuffer[5] + "'WHERE PID = '" + sqlBuffer[0] + "'AND SaleStaffID = '" + sqlBuffer[4] + "'AND SaleTime = '" + sqlBuffer[6] + "'");
                    cmd.ExecuteNonQuery();
                    break;


            }
        }
        public void Delete(string sqlCommand)//自定义Delete方法，主要用于构成并执行T-SQL语言的DELETE语句
        {
            string table = sqlCommand.Substring(0, 4);
            SqlCommand cmd;
            switch (table)
            {
                case "USER":
                    sqlBuffer = new string[1];
                    Substring(sqlCommand);
                    cmd = connect.CreateCommand();
                    cmd.CommandText = string.Format("DELETE FROM USERS WHERE UID = '" + sqlBuffer[0] +  "'");
                    cmd.ExecuteNonQuery();
                    break;
                case "STAF":
                    sqlBuffer = new string[1];
                    Substring(sqlCommand);
                    cmd = connect.CreateCommand();
                    cmd.CommandText = string.Format("DELETE FROM STAFF WHERE SID = '" + sqlBuffer[0] + "'");
                    cmd.ExecuteNonQuery();
                    break;
                case "INST":
                    sqlBuffer = new string[2];
                    Substring(sqlCommand);
                    cmd = connect.CreateCommand();
                    cmd.CommandText = string.Format("DELETE FROM INSTORE WHERE PID = '" + sqlBuffer[0] + "'AND InTime = '" + sqlBuffer[1])+"'";
                    cmd.ExecuteNonQuery();
                    break;
                case "OUST":
                    sqlBuffer = new string[2];
                    Substring(sqlCommand);
                    cmd = connect.CreateCommand();
                    cmd.CommandText = string.Format("DELETE FROM OUTSTORE WHERE PID = '" + sqlBuffer[0] + "'AND OutTime = '" + sqlBuffer[1])+"'";
                    cmd.ExecuteNonQuery();
                    break;
                case "SALE":
                    sqlBuffer = new string[3];
                    Substring(sqlCommand);
                    cmd = connect.CreateCommand();
                    cmd.CommandText = string.Format("DELETE FROM SALE WHERE PID = '" + sqlBuffer[0] + "'AND SaleStaffID = '" + sqlBuffer[1] + "'AND SaleTime = '" + sqlBuffer[2] + "'");
                    cmd.ExecuteNonQuery();
                    break;
            }
        }
        public void Insert(string sqlCommand)//自定义Insert方法，主要用于构成并执行T-SQL语言的INSERT语句
        {
            string table = sqlCommand.Substring(0, 4);
            SqlCommand cmd;
            switch(table)
            {
                case "USER":
                    sqlBuffer = new string[4];
                    Substring(sqlCommand);
                    cmd =  connect.CreateCommand();
                    cmd.CommandText = string.Format("INSERT INTO USERS "+"VALUES('"+sqlBuffer[0]+"','"
                        +sqlBuffer[1]+"',"+sqlBuffer[2]+",'"+sqlBuffer[3]+"')");
                    cmd.ExecuteNonQuery();
                    break;
                case "STAF":
                    sqlBuffer = new string[10];
                    Substring(sqlCommand);
                    cmd =  connect.CreateCommand();
                    cmd.CommandText = string.Format("INSERT INTO STAFF "+"VALUES('"+sqlBuffer[0]+"','"
                        + sqlBuffer[1] + "'," + sqlBuffer[2] + ",'" + sqlBuffer[3] + "','" + sqlBuffer[4] + "','" + sqlBuffer[5] + "','" + sqlBuffer[6] + "','"
                        +sqlBuffer[7]+"','"+sqlBuffer[8]+"',"+sqlBuffer[9]+")");
                    cmd.ExecuteNonQuery();
                    break;
                case "INST":
                    sqlBuffer = new string[5];
                    Substring(sqlCommand);
                    cmd =  connect.CreateCommand();
                    cmd.CommandText = string.Format("INSERT INTO INSTORE VALUES('"+sqlBuffer[0]+"','"
                        + sqlBuffer[1] + "'," + sqlBuffer[2] + ",'" + sqlBuffer[3] + "'," + sqlBuffer[4]+")");
                    cmd.ExecuteNonQuery();
                    break;
                case "OUST":
                    sqlBuffer = new string[4];
                    Substring(sqlCommand);
                    cmd =  connect.CreateCommand();
                    cmd.CommandText = string.Format("INSERT INTO OUTSTORE "+"VALUES('"+sqlBuffer[0]+"','"
                        + sqlBuffer[1] + "'," + sqlBuffer[2] + ",'" + sqlBuffer[3] + "')");
                    cmd.ExecuteNonQuery();
                    break;
                case "SALE":
                    sqlBuffer = new string[7];
                    Substring(sqlCommand);
                    cmd =  connect.CreateCommand();
                    cmd.CommandText = string.Format("INSERT INTO SALE "+"VALUES('"+sqlBuffer[0]+"','"
                        + sqlBuffer[1] + "'," + sqlBuffer[2] + "," + sqlBuffer[3] + ",'" + sqlBuffer[4] + "','" + sqlBuffer[5] + "','" + sqlBuffer[6] + "')");
                    cmd.ExecuteNonQuery();
                    break;
            }
        }
        public DataSet Select(string sqlCommand)//自定义Select方法，主要用于构成并执行T-SQL语言的SELECT语句,返回值为查询到的表
        {
            string table = sqlCommand.Substring(0, 4);
            DataSet ds;
            string cmd;
            SqlCommand sqlcmd;
            SqlDataAdapter sd;
            switch (table)
            {
                case "USER":
                    cmd = "SELECT UID 用户账号,UName 用户名,UPower 权限等级,Password 密码 FROM USERS";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "USERS");//用于执行SQL语句并将返回的查询结果放入DataSet型变量并返回显示
                    return ds;
                case "STAF":
                    cmd = "SELECT SID 编号,SName 姓名,SAge 年龄,SSex 性别,SAddress 住址,STel 联系电话,SSchool 学历,SDept 部门,SPosition 职位,SSalary 月薪 FROM STAFF";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "STAFF");
                    return ds;
                case "INST":
                    cmd = "SELECT PID 商品编号,PName 商品名称,PNumber 数量,InTime 入库时间,IPrice 入库单价 FROM INSTORE";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "INSTORE");
                    return ds;
                case "OUST":
                    cmd = "SELECT PID 商品编号,PName 商品名称,PNumber 数量,OutTime 出库时间 FROM OUTSTORE";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "OUTSTORE");
                    return ds;
                default:
                    cmd = "SELECT PID 商品编号,PName 商品名,PNumber 数量,SPrice 单价,SaleStaffID 销售员编号,SaleStaffName 姓名,SaleTime 销售时间 FROM SALE";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "SALE");
                    return ds;
            }
        }
        public DataSet ViewSelect(string sqlCommand)//自定义ViewSelect方法，主要用于构成并执行T-SQL语言的SELECT语句，与Select的不同之处在于此类操作都先建立视图，再查询视图，接着删除视图，最后返回查询得到的表
        {
            string table = sqlCommand.Substring(0, 4);
            DataSet ds;
            string cmd;
            SqlCommand scmd;
            SqlCommand sqlcmd;
            SqlDataAdapter sd;
            switch (table)
            {
                case "INST":
                    sqlBuffer = new string[2];
                    Substring(sqlCommand);
                    scmd =  connect.CreateCommand();
                    scmd.CommandText = string.Format("CREATE VIEW V_INSTORE(PID,PName,PNumber,InTime,IPrice)AS SELECT PID,PName,PNumber,InTime,IPrice FROM INSTORE WHERE InTime>='"
                        + sqlBuffer[0] + "'AND InTime<'"+sqlBuffer[1]+"'");
                    scmd.ExecuteNonQuery();//执行创建视图语句
                    cmd = "SELECT PID 商品编号,PName 名称,PNumber 数量,InTime 进货时间,IPrice 单价 FROM V_INSTORE";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "INSTORE");//执行查询视图语句，返回查询结果
                    scmd.CommandText = string.Format("DROP VIEW V_INSTORE");
                    scmd.ExecuteNonQuery();//执行删除视图语句
                    return ds;
                case "OUST":
                    sqlBuffer = new string[2];
                    Substring(sqlCommand);
                    scmd =  connect.CreateCommand();
                    scmd.CommandText = string.Format("CREATE VIEW V_OUTSTORE(PID,PName,PNumber,OutTime)AS SELECT PID,PName,PNumber,OutTime FROM OUTSTORE WHERE OutTime>='"
                        + sqlBuffer[0] + "'AND OutTime<'" + sqlBuffer[1] + "'");
                    scmd.ExecuteNonQuery();
                    cmd = "SELECT PID 商品编号,PName 名称,PNumber 数量,OutTime 出库时间 FROM V_OUTSTORE";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "OUTSTORE");
                    scmd.CommandText = string.Format("DROP VIEW V_OUTSTORE");
                    scmd.ExecuteNonQuery();
                    return ds;
                case "SALY":
                    sqlBuffer = new string[2];
                    Substring(sqlCommand);
                    scmd =  connect.CreateCommand();
                    scmd.CommandText = string.Format("CREATE VIEW V_SALARYS(SID,SName,Salary)AS SELECT SALARY.SID,SName,SUM(SALARY.SSalary) FROM SALARY,STAFF WHERE SALARY.SID=STAFF.SID AND SDate>='"
                        + sqlBuffer[0] + "'AND SDate<'"+sqlBuffer[1]+"'GROUP BY SALARY.SID,SName");
                    scmd.ExecuteNonQuery();
                    cmd = "SELECT SID 员工编号,SName 姓名,Salary 发放薪酬 FROM V_SALARYS";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "SALARYS");
                    scmd.CommandText = string.Format("DROP VIEW V_SALARYS");
                    scmd.ExecuteNonQuery();
                    return ds;
                case "COST":
                    sqlBuffer = new string[2];
                    Substring(sqlCommand);
                    scmd =  connect.CreateCommand();
                    scmd.CommandText = string.Format("CREATE VIEW V_COST(PID,PName,Price,Date)AS SELECT PID,PName,PNumber*IPrice,InTime FROM INSTORE WHERE InTime>='"
                        + sqlBuffer[0] + "'AND InTime<'"+sqlBuffer[1]+"'");
                    scmd.ExecuteNonQuery();
                    cmd = "SELECT PID 商品编号,PName 商品名称,Price 总价,Date 入库时间 FROM V_COST";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "COST");
                    scmd.CommandText = string.Format("DROP VIEW V_COST");
                    scmd.ExecuteNonQuery();
                    return ds;
                case "PROF":
                case "ECOM":
                    sqlBuffer = new string[2];
                    Substring(sqlCommand);
                    scmd =  connect.CreateCommand();
                    scmd.CommandText = string.Format("CREATE VIEW V_SALARYS(Salary)AS SELECT SUM(SSalary) FROM SALARY WHERE SDate>='"
                        + sqlBuffer[0] + "'AND SDate<'"+sqlBuffer[1]+"'");
                    scmd.ExecuteNonQuery();
                    scmd.CommandText = string.Format("CREATE VIEW V_INCOME(Income)AS SELECT SUM(PNumber*SPrice) FROM SALE WHERE SaleTime>='"
                        + sqlBuffer[0] + "'AND SaleTime<'"+sqlBuffer[1]+"'");
                    scmd.ExecuteNonQuery();
                    scmd.CommandText = string.Format("CREATE VIEW V_COST(Cost)AS SELECT SUM(PNumber*IPrice) FROM INSTORE WHERE InTime>='"
                        + sqlBuffer[0] + "'AND InTime<'"+sqlBuffer[1]+"'");
                    scmd.ExecuteNonQuery();
                    scmd.CommandText = string.Format("CREATE VIEW V_PROFIT(Income,Cost,Profit)AS SELECT Income,Cost+Salary,Income-Cost-Salary FROM V_SALARYS,V_INCOME,V_COST");
                    scmd.ExecuteNonQuery();
                    cmd = "SELECT Income 收入,Cost 支出,Profit 利润 FROM V_PROFIT";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "PROFIT");
                    scmd.CommandText = string.Format("DROP VIEW V_SALARYS");
                    scmd.ExecuteNonQuery();
                    scmd.CommandText = string.Format("DROP VIEW V_INCOME");
                    scmd.ExecuteNonQuery();
                    scmd.CommandText = string.Format("DROP VIEW V_COST");
                    scmd.ExecuteNonQuery();
                    scmd.CommandText = string.Format("DROP VIEW V_PROFIT");
                    scmd.ExecuteNonQuery();
                    return ds;
                case "STOR":
                    scmd =  connect.CreateCommand();
                    cmd = "SELECT PID 商品编号,PName 名称,PNumber 数量,Price 单价 FROM STORE";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "STORE");
                    return ds;
                case "SALE":
                    sqlBuffer = new string[2];
                    Substring(sqlCommand);
                    scmd =  connect.CreateCommand();
                    scmd.CommandText = string.Format("CREATE VIEW V_PRODUCT(PID,PName,PNumber,Price)AS SELECT PID,PName,SUM(PNumber),SUM(PNumber*SPrice)FROM SALE WHERE SaleTime>='"
                        + sqlBuffer[0] + "'AND SaleTime<'"+sqlBuffer[1]+"'GROUP BY PID,PName");
                    scmd.ExecuteNonQuery();
                    cmd = "SELECT PID 商品编号,PName 名称,PNumber 数量,Price 总价 FROM V_PRODUCT";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "PRODUCT");
                    scmd.CommandText = string.Format("DROP VIEW V_PRODUCT");
                    scmd.ExecuteNonQuery();
                    return ds;
                default:
                    sqlBuffer = new string[2];
                    Substring(sqlCommand);
                    scmd =  connect.CreateCommand();
                    scmd.CommandText = string.Format("CREATE VIEW V_SALER(SID,SName,PNumber,Price)AS SELECT SaleStaffID,SaleStaffName,SUM(PNumber),SUM(PNumber*SPrice)FROM SALE WHERE SaleTime>='"
                        + sqlBuffer[0] + "'AND SaleTime<'"+sqlBuffer[1]+"'GROUP BY SaleStaffID,SaleStaffName");
                    scmd.ExecuteNonQuery();
                    cmd = "SELECT SID 员工编号,SName 姓名,PNumber 数量,Price 总价 FROM V_SALER";
                    sqlcmd = new SqlCommand(cmd, connect);
                    sd = new SqlDataAdapter(sqlcmd);
                    ds = new DataSet();
                    sd.Fill(ds, "SALER");
                    scmd.CommandText = string.Format("DROP VIEW V_SALER");
                    scmd.ExecuteNonQuery();
                    return ds;
            }
        }
        public String ViewCount(string sqlCommand)//自定义ViewCount方法，主要用于构成并执行T-SQL语言的SELECT语句,独特之处在于返回的不是表信息而是具体的字符串格式的数据
        {
            string table = sqlCommand.Substring(0, 4);
            string s;
            SqlCommand scmd;
            SqlDataReader reader;
            switch (table)
            {
                case "TSAY":
                    sqlBuffer = new string[2];
                    Substring(sqlCommand);
                    scmd = connect.CreateCommand();
                    scmd.CommandText = string.Format("CREATE VIEW V_SALARYS(Salary)AS SELECT SUM(SSalary) FROM SALARY WHERE SDate>='"
                        + sqlBuffer[0] + "'AND SDate<'" + sqlBuffer[1] + "'");
                    scmd.ExecuteNonQuery();
                    scmd.CommandText = string.Format("SELECT Salary 发放薪酬 FROM V_SALARYS");
                    scmd.ExecuteNonQuery();
                    reader = scmd.ExecuteReader();//返回信息放入SqlDataReader型变量中
                    reader.Read();//读取字段信息并转换成字符串形式保存
                    s = reader[0].ToString();
                    reader.Close();//在执行下条SQL语句前关闭SqlDataReader变量
                    scmd.CommandText = string.Format("DROP VIEW V_SALARYS");
                    scmd.ExecuteNonQuery();
                    return s; 
                case "TCST":
                    sqlBuffer = new string[2];
                    Substring(sqlCommand);
                    scmd = connect.CreateCommand();
                    scmd.CommandText = string.Format("CREATE VIEW V_COST(Cost)AS SELECT SUM(PNumber*IPrice) FROM INSTORE WHERE InTime>='"
                        + sqlBuffer[0] + "'AND InTime<'" + sqlBuffer[1] + "'");
                    scmd.ExecuteNonQuery();
                    scmd.CommandText = string.Format("SELECT Cost 产品成本 FROM V_COST");
                    scmd.ExecuteNonQuery();
                    reader = scmd.ExecuteReader();
                    reader.Read();
                    s = reader[0].ToString();
                    reader.Close();
                    scmd.CommandText = string.Format("DROP VIEW V_COST");
                    scmd.ExecuteNonQuery();
                    return s; 
                default:
                    return "";
            }
        }
        public SqlDataReader ViewCount(string command1, string command2)//重构ViewCount方法，主要用于构成并执行T-SQL语言的SELECT语句,特地用于需要返回一行数据的登录模块
        {
            SqlCommand scmd;
            SqlDataReader reader;
            scmd = connect.CreateCommand();
            scmd.CommandText = string.Format("SELECT * FROM USERS WHERE UID = '" + command1 + "'AND Password = '" + command2 + "'");
            scmd.ExecuteNonQuery();
            reader = scmd.ExecuteReader();
            SqlDataReader s = reader;
            return reader;//返回整行数据

        }
        public void Close()//自定义Close方法，用于关闭SQL连接
        {
            connect.Close();
        }
    }
}
