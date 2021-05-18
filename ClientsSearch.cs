using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cascade0.Models;
using System.Data.Entity;
using System.Reflection;
using System.Linq.Expressions;
using Cascade0.Controllers.DataTransferObjects;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Microsoft.IdentityModel.Tokens;
using SQLitePCL;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;

namespace Cascade0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clients1Controller : ControllerBase
    {
        private readonly DDSPRODDBContext _context;
        private static MethodCallExpression bodyLike;
        private static MethodCallExpression bodyLikeStart;
        private static BinaryExpression body;

        public Clients1Controller()
        {
            DDSPRODDBContext context = new DDSPRODDBContext();
            _context = context;
        }
        private IQueryable<Client> GenerateClause(string propName, string selectedOperator, ClientDTO Emp)
        {
            var propertyInfo = typeof(Client).GetProperty(propName);
            object fieldValue;
            fieldValue = Emp.parameterValue;
            var db = _context.Client.Where(PropertyEquals1<Client, string>(propertyInfo, selectedOperator, propName, fieldValue, Emp));
            return db;
        }
        private IQueryable<Client> GenerateClause2(string propName, string propName2, string selectedOperator, string selectedOperator2, ClientDTO Emp)
        {
            var propertyInfo = typeof(Client).GetProperty(propName);
            var propertyInfo2 = typeof(Client).GetProperty(propName2);

            object fieldValue; object fieldValue2;
            fieldValue2 = Emp.parameterValue2;
            fieldValue = Emp.parameterValue;
            var db = _context.Client.Where(PropertyEquals2<Client, string>(propertyInfo, propertyInfo2, selectedOperator, selectedOperator2, Emp.parameterValue, Emp.parameterValue2, Emp));
            return db;
        }
        private IQueryable<Client> GenerateClause3(string propName, string propName2, string propName3, string selectedOperator, string selectedOperator2, string selectedOperator3, ClientDTO Emp)
        {
            var propertyInfo = typeof(Client).GetProperty(propName);
            var propertyInfo2 = typeof(Client).GetProperty(propName2);
            var propertyInfo3 = typeof(Client).GetProperty(propName3);

            var db = _context.Client.Where(PropertyEquals3<Client, string>(propertyInfo, propertyInfo2, propertyInfo3, selectedOperator, selectedOperator2, selectedOperator3, Emp));

            if (db != null)
            {
                return db;
            }




            throw new NotImplementedException();
        }
        private IQueryable<Client> GenerateClause4(string propName, string propName2, string propName3, string propName4, string selectedOperator, string selectedOperator2, string selectedOperator3, string selectedOperator4, ClientDTO Emp)
        {
            var propertyInfo = typeof(Client).GetProperty(propName);
            var propertyInfo2 = typeof(Client).GetProperty(propName2);
            var propertyInfo3 = typeof(Client).GetProperty(propName3);
            var propertyInfo4 = typeof(Client).GetProperty(propName4);

            var db = _context.Client.Where(PropertyEquals4<Client, string>(propertyInfo, propertyInfo2, propertyInfo3, propertyInfo4, selectedOperator, selectedOperator2, selectedOperator3, selectedOperator4, Emp));

            if (db != null)
            {
                return db;
            }




            throw new NotImplementedException();
        }

        public virtual Expression<Func<Client, bool>> WhereFilter
        {
            get { return x => true; }
        }

        public static MethodInfo StartsWith { get; private set; }

        [HttpGet]
        // GET: api/Employees1
        [Route("GetEmployee")]
        public async Task<List<Client>> GetEmployee(string propName, [FromBody] ClientDTO employee, string selectedOperator)
        {
            string columnName = employee.columnName;



            var parameterValue = employee.parameterValue;
            string columnNameRecieved = columnName;
            Type myType = typeof(Client);
            //GenerateClause(propName , selectedOperator, employee);



            var GrabStatement = GenerateClause(propName, selectedOperator, employee);
            return GrabStatement.ToList();

        }
        [HttpGet]
        [Route("GetEmployeeSet3")]
        public async Task<List<Client>> GetQuerySetThree(string propName, string propName2, string propName3, [FromBody] ClientDTO employee, string selectedOperator, string selectedOperator2, string selectedOperator3)
        {
            var GrabStatement = GenerateClause3(propName, propName2, propName3, selectedOperator, selectedOperator2, selectedOperator3, employee);
            return GrabStatement.ToList();

        }
        [HttpGet]
        [Route("GetEmployeeSet4")]
        public async Task<List<Client>> GetQuerySetFour(string propName, string propName2, string propName3, string propName4, [FromBody] ClientDTO employee, string selectedOperator, string selectedOperator2, string selectedOperator3, string selectedOperator4)
        {
            var GrabStatement = GenerateClause4(propName, propName2, propName3, propName4, selectedOperator, selectedOperator2, selectedOperator3, selectedOperator4, employee);
            return GrabStatement.ToList();

        }

        [HttpGet]
        [Route("GetEmployeeSet2")]
        public async Task<List<Client>> GetQuerySetTwo(string propName, string propName2, [FromBody] ClientDTO employee, string selectedOperator, string selectedOperator2)
        {
            string columnName = employee.columnName;
            var parameterValue = employee.parameterValue;
            var GrabStatement = GenerateClause2(propName, propName2, selectedOperator, selectedOperator2, employee);
            return GrabStatement.ToList();
        }

        public static Expression<Func<TItem, bool>> PropertyEquals3<TItem, TValue>(PropertyInfo propName, PropertyInfo propName2, PropertyInfo propName3, string selectedOperator, string selectedOperator2, string selectedOperator3, ClientDTO employee)
        {

            var parameter = Expression.Parameter(typeof(Client)); var expressionParameter = GetMemberExpression<T>(parameter, propName.Name);
            MethodInfo contains = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            MethodInfo StartsWith = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });

            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            PropertyDescriptor prop = GetProperty(props, employee.parameterValue, true);

            body = null;
            if (selectedOperator == "contains")
            {
                if (propName2.PropertyType == typeof(int))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((employee.parameterValueInt4)));
                }
                if (propName2.PropertyType == typeof(DateTime))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((employee.parameterValueDateTime4, typeof(DateTime?))));
                }
                if (propName2.PropertyType == typeof(string))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((string)(employee.parameterValue4)));
                }
                else
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(Convert.ToString(employee.parameterValueUndeclared)));

                }
            }

            if (employee != null)   // if the property is null and the object recieved is null we are going to write the appropriate expression and return it
            {
                if (!string.IsNullOrWhiteSpace(employee.parameterValue))
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValue));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                            Expression.And(bodyLike, bodyLike);
                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(employee.parameterValue));


                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                               Expression.And(bodyLike, bodyLike);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueInt != null)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValueInt, typeof(int)));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(employee.parameterValueInt, typeof(int)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body =
                               Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueDateTime == DateTime.MinValue)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body =
         Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body =
         Expression.And(bodyLike, bodyLike);

                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
            }
            if (employee.Or == false)
            {
                if (!string.IsNullOrWhiteSpace(employee.parameterValue2))
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":

                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValue2));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValue2));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueInt2 != null)
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueInt2, typeof(int)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (employee.parameterValueDateTime2 == DateTime.MinValue)
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(employee.parameterValue2))
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThanOrEquals":
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValue));

                                if (body != null)
                                {
                                    body = Expression.And(bodyLike, body);
                                    break;
                                }
                                else
                                {
                                    body =
                                 Expression.And(bodyLike, bodyLike);
                                    break;
                                }
                                break;

                            case "StartsWith":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValue2));

                                if (body != null)
                                {
                                    body = Expression.And(bodyLike, body);
                                    break;
                                }
                                else
                                {
                                    body =
                                 Expression.And(bodyLike, bodyLike);
                                    break;
                                }
                                break;

                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }
                }

            }
            if (employee.parameterValueInt2 != null)
            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        var stomach
                            = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                         Expression.And(bodyLike, bodyLike);
                            break;
                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                         Expression.And(bodyLike, bodyLike);
                            break;
                        }
                        break;
                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }
            if (employee.parameterValueDateTime2 == DateTime.MinValue)
            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                           Expression.And(bodyLike, bodyLike);
                            break;
                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                              Expression.And(bodyLike, bodyLike);
                            break;
                        }
                        break;
                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }
            if (!string.IsNullOrWhiteSpace(employee.parameterValue2))
            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValue2));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                         Expression.And(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValue2));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                         Expression.And(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        break;

                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }


            if (employee.Or2 == false)
            {
                if (!string.IsNullOrWhiteSpace(employee.parameterValue3))
                {
                    switch (selectedOperator3)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName3), contains, Expression.Constant(employee.parameterValue3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName3), StartsWith, Expression.Constant(employee.parameterValue3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                                  Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (employee.parameterValueDateTime3 == DateTime.MinValue)
                {
                    switch (selectedOperator3)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName3), contains, Expression.Constant(employee.parameterValueDateTime3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName3), StartsWith, Expression.Constant(employee.parameterValueDateTime3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (!string.IsNullOrWhiteSpace(employee.parameterValue3))
                {
                    switch (selectedOperator3)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName3), contains, Expression.Constant(employee.parameterValueDateTime3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName3), StartsWith, Expression.Constant(employee.parameterValueDateTime3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }

                    if (employee.parameterValueInt3 != null)
                    {
                        switch (selectedOperator3)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                var stomach = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                            case "GreaterThanOrEquals":
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName3), contains, Expression.Constant(employee.parameterValueInt3, typeof(int?)));

                                if (body != null)
                                {
                                    body = Expression.And(bodyLike, body);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                else
                                {
                                    body =
                                 Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                break;
                            case "StartsWith":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName3), StartsWith, Expression.Constant(employee.parameterValueInt3, typeof(int?)));

                                if (body != null)
                                {
                                    body = Expression.And(bodyLike, body);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                else
                                {
                                    body =
                                  Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                break;

                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }
                }
            }
            if (employee.parameterValueInt3 != null)
            {
                switch (selectedOperator3)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Convert(Expression.Constant(employee.parameterValueInt3), typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName3), contains, Expression.Constant(employee.parameterValueInt3, typeof(int?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                            Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName3), StartsWith, Expression.Constant(employee.parameterValueInt3, typeof(int?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        break;

                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }
            if (employee.parameterValueDateTime3 == DateTime.MinValue)

            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName3), contains, Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }


                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName3), StartsWith, Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                          Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        break;

                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }

            throw new Exception("Not implement Operation");


        }


        public static Expression<Func<TItem, bool>> PropertyEquals4<TItem, TValue>(PropertyInfo propName, PropertyInfo propName2, PropertyInfo propName3, PropertyInfo propName4, string selectedOperator, string selectedOperator2, string selectedOperator3, string selectedOperator4, ClientDTO employee)
        {

            var parameter = Expression.Parameter(typeof(Client)); var expressionParameter = GetMemberExpression<T>(parameter, propName.Name);
            MethodInfo contains = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            MethodInfo StartsWith = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });

            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            PropertyDescriptor prop = GetProperty(props, employee.parameterValue, true);

            body = null;
            if (selectedOperator == "contains")
            {
                if (propName2.PropertyType == typeof(int))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((employee.parameterValueInt4)));
                }
                if (propName2.PropertyType == typeof(DateTime))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((employee.parameterValueDateTime4, typeof(DateTime?))));
                }
                if (propName2.PropertyType == typeof(string))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((string)(employee.parameterValue4)));
                }
                else
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(Convert.ToString(employee.parameterValueUndeclared)));

                }
            }

            if (employee != null)   // if the property is null and the object recieved is null we are going to write the appropriate expression and return it
            {
                if (!string.IsNullOrWhiteSpace(employee.parameterValue))
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValue));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                            Expression.And(bodyLike, bodyLike);
                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(employee.parameterValue));


                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                               Expression.And(bodyLike, bodyLike);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueInt != null)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValueInt, typeof(int)));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(employee.parameterValueInt, typeof(int)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body =
                               Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueDateTime == DateTime.MinValue)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body =
         Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body =
         Expression.And(bodyLike, bodyLike);

                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
            }
            if (employee.Or == false)
            {
                if (!string.IsNullOrWhiteSpace(employee.parameterValue2))
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":

                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValue2));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValue2));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueInt2 != null)
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueInt2, typeof(int)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (employee.parameterValueDateTime2 == DateTime.MinValue)
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(employee.parameterValue2))
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThanOrEquals":
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValue));

                                if (body != null)
                                {
                                    body = Expression.And(bodyLike, body);
                                    break;
                                }
                                else
                                {
                                    body =
                                 Expression.And(bodyLike, bodyLike);
                                    break;
                                }
                                break;

                            case "StartsWith":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValue2));

                                if (body != null)
                                {
                                    body = Expression.And(bodyLike, body);
                                    break;
                                }
                                else
                                {
                                    body =
                                 Expression.And(bodyLike, bodyLike);
                                    break;
                                }
                                break;

                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }
                }

            }
            if (employee.parameterValueInt2 != null)
            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        var stomach = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                         Expression.And(bodyLike, bodyLike);
                            break;
                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                         Expression.And(bodyLike, bodyLike);
                            break;
                        }
                        break;
                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }
            if (employee.parameterValueDateTime2 == DateTime.MinValue)
            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                         Expression.And(bodyLike, bodyLike);
                            break;
                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                         Expression.And(bodyLike, bodyLike);
                            break;
                        }
                        break;
                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }
            if (!string.IsNullOrWhiteSpace(employee.parameterValue2))
            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValue2));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                         Expression.And(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValue2));

                        if (body != null)
                        {
                            body = Expression.And(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                         Expression.And(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        break;

                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }


            if (employee.Or2 == false)
            {
                if (!string.IsNullOrWhiteSpace(employee.parameterValue3))
                {
                    switch (selectedOperator3)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValue3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValue3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                                 Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (employee.parameterValueDateTime3 == DateTime.MinValue)
                {
                    switch (selectedOperator3)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueDateTime3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);
                                break;
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueDateTime3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (!string.IsNullOrWhiteSpace(employee.parameterValue3))
                {
                    switch (selectedOperator3)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValue3)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueDateTime3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);
                                break;
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueDateTime3));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                break;
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }

                    if (employee.parameterValueInt3 != null)
                    {
                        switch (selectedOperator3)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                break;
                            case "NotEqual":
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                break;
                            case "LessThan":
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                break;
                            case "LessThanOrEqual":
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                break;
                            case "GreaterThan":
                                var stomach = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                break;
                            case "GreaterThanOrEquals":
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                                break;
                            case "Like":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueInt3, typeof(int?)));

                                if (body != null)
                                {
                                    body = Expression.And(bodyLike, body);
                                    break;
                                }
                                else
                                {
                                    body =
                                  Expression.And(bodyLike, bodyLike);
                                    break;
                                }

                            case "StartsWith":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueInt3, typeof(int?)));

                                if (body != null)
                                {
                                    body = Expression.And(bodyLike, body);
                                    break;
                                }
                                else
                                {
                                    body =
                                    Expression.And(bodyLike, bodyLike);
                                    break;
                                }


                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }
                }
            }
            if (employee.parameterValueInt3 != null)
            {
                switch (selectedOperator3)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                        break;
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Convert(Expression.Constant(employee.parameterValueInt3), typeof(int?))));
                        break;
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                        break;
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                        break;
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                        break;
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(employee.parameterValueInt3, typeof(int?))));
                        break;
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueInt3, typeof(int?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                          Expression.Or(bodyLike, bodyLike);
                            break;
                        }

                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueInt3, typeof(int?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                         Expression.Or(bodyLike, bodyLike);
                            break;
                        }


                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }
            if (employee.parameterValueDateTime3 == DateTime.MinValue)

            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                          Expression.Or(bodyLike, bodyLike);
                            break;
                        }


                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueDateTime3, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            break;
                        }
                        else
                        {
                            body =
                           Expression.Or(bodyLike, bodyLike);
                            break;
                        }
                        break;

                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }

            }





            if (employee.Or3 == false)
            {
                if (!string.IsNullOrWhiteSpace(employee.parameterValue4))
                {
                    switch (selectedOperator4)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(employee.parameterValue4));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(employee.parameterValue4));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                                Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (employee.parameterValueDateTime4 == DateTime.MinValue)
                {
                    switch (selectedOperator4)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(employee.parameterValueDateTime4));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(employee.parameterValueDateTime4));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (!string.IsNullOrWhiteSpace(employee.parameterValue4))
                {
                    switch (selectedOperator4)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(employee.parameterValue4));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(employee.parameterValue4));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }

                    if (employee.parameterValueInt4 != null)
                    {
                        switch (selectedOperator4)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                var stomach = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                            case "GreaterThanOrEquals":
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(employee.parameterValueInt4, typeof(int?)));

                                if (body != null)
                                {
                                    body = Expression.And(bodyLike, body);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                else
                                {
                                    body =
                                 Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                break;
                            case "StartsWith":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(employee.parameterValueInt4, typeof(int?)));

                                if (body != null)
                                {
                                    body = Expression.And(bodyLike, body);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                else
                                {
                                    body =
                                 Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                break;

                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }
                }
            }
            if (employee.parameterValueInt4 != null)
            {
                switch (selectedOperator4)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueInt4, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Convert(Expression.Constant(employee.parameterValueInt4), typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueInt4, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueInt4, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueInt4, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueInt4, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(employee.parameterValueInt4, typeof(int?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(employee.parameterValueInt4, typeof(int?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        break;

                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }
            if (employee.parameterValueDateTime4 == DateTime.MinValue)

            {
                switch (selectedOperator4)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        break;


                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(employee.parameterValueDateTime4, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        else
                        {
                            body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        }
                        break;

                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }

            }

            throw new Exception("Not implement Operation");


        }


        public static Expression<Func<TItem, bool>> PropertyEquals2<TItem, TValue>(PropertyInfo propName, PropertyInfo propName2, string selectedOperator, string selectedOperator2, object value, object value2, ClientDTO employee)
        {

            var parameter = Expression.Parameter(typeof(Client)); var expressionParameter = GetMemberExpression<T>(parameter, propName.Name);
            MethodInfo contains = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            MethodInfo StartsWith = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });

            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            PropertyDescriptor prop = GetProperty(props, employee.parameterValue, true);

            body = null;
            if (selectedOperator == "contains")
            {
                if (propName2.PropertyType == typeof(int))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((employee.parameterValueInt4)));
                }
                if (propName2.PropertyType == typeof(DateTime))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((employee.parameterValueDateTime4, typeof(DateTime?))));
                }
                if (propName2.PropertyType == typeof(string))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((string)(employee.parameterValue4)));
                }
                else
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(Convert.ToString(employee.parameterValueUndeclared)));

                }
            }

            if (employee != null)   // if the property is null and the object recieved is null we are going to write the appropriate expression and return it
            {
                if (!string.IsNullOrWhiteSpace(employee.parameterValue))
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValue));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(employee.parameterValue));


                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueInt != null)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValueInt, typeof(int?)));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(employee.parameterValueInt, typeof(int?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body =
                               Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueDateTime == DateTime.MinValue)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body =
         Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body =
         Expression.And(bodyLike, bodyLike);

                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
            }
            if (employee.Or == false)
            {
                if (!string.IsNullOrWhiteSpace(employee.parameterValue2))
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            var expressions = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(expressions, parameter);
                        case "NotEqual":
                            var stomach = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "LessThan":
                            stomach = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "LessThanOrEqual":
                            stomach = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "GreaterThan":
                            stomach = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "GreaterThanOrEquals":
                            stomach = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "Like":

                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValue2));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValue2));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            break;
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueInt2 != null)
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            var expressions = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(expressions, parameter);
                        case "NotEqual":
                            var stomach = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "LessThan":
                            stomach = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "LessThanOrEqual":
                            stomach = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            stomach = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            break;
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueInt2 != null)
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            var expressions = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(expressions, parameter);
                        case "NotEqual":
                            var stomach = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "LessThan":
                            stomach = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "LessThanOrEqual":
                            stomach = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "GreaterThan":
                            stomach = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "GreaterThanOrEquals":
                            stomach = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                            if (body != null)
                            {
                                body = Expression.Or(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            else
                            {
                                body =
                             Expression.Or(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                            if (body != null)
                            {
                                body = Expression.Or(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            else
                            {
                                body =
                             Expression.Or(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            break;
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueDateTime2 == DateTime.MinValue)
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (!string.IsNullOrWhiteSpace(employee.parameterValue2))
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValue2)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValue));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            break;

                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValue2));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (employee.parameterValueInt2 != null)
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt2, typeof(int?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueInt2, typeof(int?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                            }
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
            }
            if (employee.parameterValueDateTime2 == DateTime.MinValue)
            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                        }
                        else
                        {
                            body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(employee.parameterValueDateTime2, typeof(DateTime?)));

                        if (body != null)
                        {
                            body = Expression.Or(bodyLike, body);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                        }
                        else
                        {
                            body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                        }
                        break;
                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }

            throw new Exception("Not implement Operation");
        }
        public static Expression<Func<TItem, bool>> PropertyEquals1<TItem, TValue>(PropertyInfo propName, string selectedOperator, string propNameString, object fieldValue, ClientDTO employee)
        {
            bool where;
            Type myType = typeof(Client);
            var PropertyInfo = myType.GetProperty(propNameString);

            var parameter = Expression.Parameter(typeof(Client));
            var idproperty = myType.GetProperty(propNameString);
            MethodInfo contains = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            MethodInfo startsWith = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(Client));
            PropertyDescriptor prop = GetProperty(props, propNameString, true);
            var expressionParameter = GetMemberExpression<T>(parameter, propName.Name);
            body = null;
            if (employee != null)   // if the property is null and the object recieved is null we are going to write the appropriate expression and return it
            {
                if (!string.IsNullOrWhiteSpace(employee.parameterValue))
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValue));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValue));
                            return Expression.Lambda<Func<TItem, bool>>(bodyLike, parameter);
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), startsWith, Expression.Constant(employee.parameterValue));
                            return Expression.Lambda<Func<TItem, bool>>(bodyLike, parameter);
                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueInt != null)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValueInt, typeof(int?)));
                            return Expression.Lambda<Func<TItem, bool>>(bodyLike, parameter);
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), startsWith, Expression.Constant(employee.parameterValue, typeof(int?)));
                            return Expression.Lambda<Func<TItem, bool>>(bodyLike, parameter);

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
                if (employee.parameterValueDateTime == DateTime.MinValue)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(employee.parameterValueDateTime, typeof(DateTime?)));
                            return Expression.Lambda<Func<TItem, bool>>(bodyLike, parameter);
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), startsWith, Expression.Constant(employee.parameterValue, typeof(DateTime?)));
                            return Expression.Lambda<Func<TItem, bool>>(bodyLike, parameter);

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }
            }
            else
            {
                Expression<Func<TItem, bool>> filter = x => true;
                return filter;
            }
            DefaultExpression emptyExpr = Expression.Empty();

            var emptyBlock = Expression.Block(emptyExpr);
            throw new Exception("Code failed");
        }
        private static MemberExpression GetMemberExpression<T>(ParameterExpression parameter, string propName)
        {
            if (string.IsNullOrEmpty(propName)) return null;
            var propertiesName = propName.Split('.');
            if (propertiesName.Count() == 2)
                return Expression.Property(Expression.Property(parameter, propertiesName[0]), propertiesName[1]);
            return Expression.Property(parameter, propName);
        }
        //
        private static PropertyDescriptor GetProperty(PropertyDescriptorCollection props, string fieldName, bool ignoreCase)
        {
            if (!fieldName.Contains('.'))
                return props.Find(fieldName, ignoreCase); //grab the operand if false returns the property descriptor if true ignore the case 

            var fieldNameProperty = fieldName.Split('.');
            return props.Find(fieldNameProperty[0], ignoreCase).GetChildProperties().Find(fieldNameProperty[1], ignoreCase);

        }
        private IQueryable<Employee> GenerateEqualsStatement(Type myType, EmployeeSignUpDTO employee, string propName)
        {
            myType = typeof(Employee);
            var PropertyInfo = myType.GetProperty(propName);

            return Enumerable.Empty<Employee>().AsQueryable();

        }

        private static Expression<Func<TItem, bool>> Contains2<TItem>(object fieldValue, ParameterExpression parameterExpression, MemberExpression memberExpression)
        {
            var list = (List<long>)fieldValue;

            if (list == null || list.Count == 0) return x => true;

            MethodInfo containsInList = typeof(List<long>).GetMethod("Contains", new Type[] { typeof(long) });
            var bodyContains = Expression.Call(Expression.Constant(fieldValue), containsInList, memberExpression);

            return Expression.Lambda<Func<TItem, bool>>(bodyContains, parameterExpression);
        }

        public enum OperationExpression
        {
            Equals,
            NotEquals,
            Minor,
            MinorEquals,
            Mayor,
            MayorEquals,
            Like,

            Any
        }

        public static Expression<Func<TIn, bool>> PropertyEqualsExp<TIn, TOut>(PropertyInfo property, TOut value)
        {
            var param = Expression.Parameter(typeof(TIn));
            var body = Expression.Equal(Expression.Property(param, property), Expression.Constant(value));
            return Expression.Lambda<Func<TIn, bool>>(body, param);
        }
        public static Expression<Func<TIn, bool>> PropertyIsBetween<TIn, TOut>(PropertyInfo property, TOut value)
        {
            var param = Expression.Parameter(typeof(TIn));
            var body = Expression.LessThan(Expression.Property(param, property), Expression.Constant(value));
            return Expression.Lambda<Func<TIn, bool>>(body, param);
        }
    }
}