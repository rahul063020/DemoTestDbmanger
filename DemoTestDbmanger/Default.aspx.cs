using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBManager;
using System.Configuration;
using System.Reflection;
using System.Threading.Tasks;
using Model.DemoTestDbmanger;
using System.Data;
using DemoTestDbmanger.DataModel;
namespace DemoTestDbmanger
{
    public partial class Default : System.Web.UI.Page
    {
        delegate int del(int i);
        delegate String delStrng(String i);
        delegate Havoc delHavoc(Havoc havoc);
        protected void Page_Load(object sender, EventArgs e)
         {
             MediaConnection.Instance().ConnectionString = ConfigurationManager.ConnectionStrings["ConnStringDb"].ToString();
             DBContext<School> lst = new DBContext<School>();
            
             List<School> lstSch = lst.Result;
             int id = lst.NextIncrementID;
             lst.Result = new List<School>();
             lst.Result.Add(new School {later=3, Count = 2, CreatedAt = DateTime.Now, GuId = Guid.NewGuid(), Name = "Prtfght", Role = 23, USER_ID = 1 });

             lst.SaveChanges();

             // lst.SyncDbEntity();
             //  lst.Select.ID = 1;

             // List<School> drt = lst.Result;

             //lst.Result[0].GuId = Guid.NewGuid();
             //for (int i = 1; i < 30;i++ )
             //{
             //    lst.Result.Add(new School { Count = i, CreatedAt = DateTime.Now, GuId = new Guid(), Name = "" + i, Role = i });
             //}

             Test ds = new Test();
             for (int i = 1; i < 3; i++)
             {
                 DataRow dr = ds.School.NewRow();
                 dr["ID"] = i;
                 dr["Name"] = "" + i;
                 dr["Role"] = i;
                 dr["Count"] = i;
                 dr["GuId"] = Guid.NewGuid();
                 dr["CreatedAt"] = DateTime.Now;
                 dr["USER_ID"] = 2;
                 ds.School.Rows.Add(dr);
             }
             DBMContext contxt = new DBMContext();
             contxt.SaveRecords(ds);
             IProduction pro = new Production();
             String query = pro.produceDataSetUpdateQuery(ds);
           // delegate int del(int i);

            //del myDelegate = x => x * x;
            //int j = myDelegate(5); //j = 25

            //delStrng deltest1 = new delStrng(Test1);
            //String str = deltest1("2");

            //delHavoc delHavoc = new delHavoc(HavocTest1);
           
            //delHavoc=x=>x.ID==1 
            

                // MediaConnection.Instance().ConnectionString = ConfigurationManager.ConnectionStrings["ConnStringDb"].ToString();
                 // String AssemblyReference = "SpdySvc.Models";
                 String AssemblyReference = "Model.DemoTestDbmanger";
                 List<Type> theList = Assembly.GetExecutingAssembly().GetTypes().ToList().Where(t => t.Namespace == AssemblyReference).ToList();
                 MediaConnection.Instance().AllEntity = theList;
                 theList.Add(typeof(School));
                 var context = new DBMContext();
                 context.SyncEntity();
           //   lblMessage.Text = context.Message;

            //var d1 = typeof(Task<>);
            //Type[] typeArgs = { typeof(Havoc) };
            //var makeme = d1.MakeGenericType(typeArgs);

            //String AssemblyReference = "Model.DemoTestDbmanger";

            //List<Type> theList = Assembly.GetExecutingAssembly().GetTypes().ToList().Where(t => t.Namespace == AssemblyReference).ToList();           

            //MediaConnection.Instance().ConnectionString = ConfigurationManager.ConnectionStrings["ConnStringDb"].ToString();

            //var context = new DBMContext();

            //using (context)
            //{
            //    var typeOfContext = context.GetType();

            //    var method = typeOfContext.GetMethod("ExecuteEntity");

            //    var genericMethod = method.MakeGenericMethod(theList[0]);
            //    genericMethod.Invoke(context, null);
            //}

            //using (var context = new DBMContext())
            //{
            //    context.ExecuteEntity<Havoc>();
                
            //}
        }

        private Havoc HavocTest1(Havoc havoc)
        {
            throw new NotImplementedException();
        }

        private String Test1(String i)
        {
            return "Hello:" + i;
        }

       
        public class Base<T>
        {
          
        }

    }

    public class GetRecord<T>
    {
        public  void Where(String lineQuery)
        {
            Query = lineQuery;
        }

        private String Query { get; set; }

        private  bool hasvalue;
        private List<GENERI_CCLAUSE<T>> _lstrecord;
        private List<GENERI_CCLAUSE<T>> lstrecord
        {
            get
            {
                return _lstrecord;
            }
            set
            {
                _lstrecord = value;
            }
        }

        public GetRecord()
        {
            Select = Activator.CreateInstance<T>();
        }

        private List<T> _Result;
        public List<T> Result
        {
            get
            {                
                return FindResult();
            }
            set
            {
                _Result = value;
            }
        }

        private T _Select;
        public  T Select
        {
            get
            {
                return _Select;
            }
            set
            {
                _Select = value;
            }
        }


        private List<T> FindResult()
        {
            Setproperty();
            return new List<T>();
        }
        public void UpdateRecords()
        {



        }
        private void Setproperty()
        {
            IProduction pro = new InitializeProduction().Initalize<T>();
            if (Query != null)
            {
                GENERI_CCLAUSE<T> mdl = new GENERI_CCLAUSE<T>();
                mdl.clause = Select;
                mdl.clauseOprtr = ClauseOperator.NONE;
                lstrecord = new List<GENERI_CCLAUSE<T>>();
                lstrecord.Add(mdl);                
                String query = pro.CreateQuery<T>(lstrecord);
            }
            else
            {
                Query += "SELECT * FROM [" + pro.TABLE_NAME + "] WHERE " + Query;
            }
        }
        public void AddRecords()
        {

        }
        public void SaveChanges()
        {

        }

    }


    [DataMember(TABLE_NAME="HAVOC",ID_FIELD="ID")]
    public class Havoc 
    {
        [DataMember(SYNC_PROERTY=false)]
        public int ID { get; set; }
        public String Name { get; set; }
        public int Role { get; set; }
        public double Count { get; set; }
        public Guid GuId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}