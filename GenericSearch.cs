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
using System.ComponentModel.DataAnnotations;
using AutoMapper.Internal;
using Castle.Core.Internal;
using Cascade0.Helpers;

namespace Cascade0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ts1Controller : ControllerBase
    {
        private readonly DDSPRODDBContext _context;
        private static MethodCallExpression bodyLike;
        private static MethodCallExpression bodyLikeStart;
        private static BinaryExpression body;
        private readonly IOnPageLoadHelper _onPageLoadHelper;

        public Ts1Controller(IOnPageLoadHelper onPageLoadHelper)
        {
            DDSPRODDBContext context = new DDSPRODDBContext();
            _onPageLoadHelper = onPageLoadHelper;

            _context = context;
        }
        private IQueryable<Branch> GenerateClause(string propName, string selectedOperator, GenericObject Emp)
        {
            var propertyInfo = typeof(Branch).GetProperty(propName);
            object fieldValue;
            fieldValue = Emp.parameterValue;
            var db = _context.Branch.Where(PropertyEquals1<Branch, string>(propertyInfo, selectedOperator, propName, fieldValue, Emp));
            return db;
        }
        private IQueryable<Branch> GenerateClause2(string propName, string propName2, string selectedOperator, string selectedOperator2, GenericObject Emp)
        {
            var propertyInfo = typeof(T).GetProperty(propName);
            var propertyInfo2 = typeof(T).GetProperty(propName2);

            object fieldValue; object fieldValue2;
            fieldValue2 = Emp.parameterValue2;
            fieldValue = Emp.parameterValue;
            var db = _context.Branch.Where(PropertyEquals2<Branch, string>(propertyInfo, propertyInfo2, selectedOperator, selectedOperator2, Emp.parameterValue, Emp.parameterValue2, Emp, propName, propName2));
            return db;
        }
        private IQueryable<Branch> GenerateClause3(string propName, string propName2, string propName3, string selectedOperator, string selectedOperator2, string selectedOperator3, GenericObject Emp)
        {
            var propertyInfo = typeof(Branch).GetProperty(propName);
            var propertyInfo2 = typeof(Branch).GetProperty(propName2);
            var propertyInfo3 = typeof(Branch).GetProperty(propName3);

            var db = _context.Branch.Where(PropertyEquals3<Branch, string>(propertyInfo, propertyInfo2, propertyInfo3, selectedOperator, selectedOperator2, selectedOperator3, Emp, propName, propName2, propName3));

            if (db != null)
            {
                return db;
            }
            throw new NotImplementedException();
        }
        private IQueryable<Branch> GenerateClause4(string propName, string propName2, string propName3, string propName4, string selectedOperator, string selectedOperator2, string selectedOperator3, string selectedOperator4, GenericObject Emp)
        {
            var propertyInfo = typeof(T).GetProperty(propName);
            var propertyInfo2 = typeof(T).GetProperty(propName2);
            var propertyInfo4 = typeof(T).GetProperty(propName4);
            var propertyInfo3 = typeof(T).GetProperty(propName3);

            var db = _context.Branch.Where(PropertyEquals4<Branch, string>(propertyInfo, propertyInfo2, propertyInfo3, propertyInfo4, selectedOperator, selectedOperator2, selectedOperator3, selectedOperator4, Emp));

            if (db != null)
            {
                return db;
            }
            throw new NotImplementedException();
        }

        public virtual Expression<Func<T, bool>> WhereFilter
        {
            get { return x => true; }
        }

        public static MethodInfo StartsWith { get; private set; }

        [HttpPost]
        // GET: api/Ts1
        [Route("GetTSet1")]
        public async Task<List<Branch>> GetT(string propName, [FromBody] GenericObject T, string selectedOperator)
        {
            string columnName = T.columnName;
            var parameterValue = T.parameterValue;
            string columnNameRecieved = columnName;
            Type myType = typeof(T);
            //GenerateClause(propName , selectedOperator, T);



            var GrabStatement = GenerateClause(propName, selectedOperator, T);
            return GrabStatement.ToList();

        }
        [HttpPost]
        [Route("GetTSet3")]
        public async Task<List<Branch>> GetQuerySetThree(string propName, string propName2, string propName3, [FromBody] GenericObject T, string selectedOperator, string selectedOperator2, string selectedOperator3)
        {
            var GrabStatement = GenerateClause3(propName, propName2, propName3, selectedOperator, selectedOperator2, selectedOperator3, T);
            return GrabStatement.ToList();

        }
        [HttpPost]
        [Route("GetTSet4")]
        public async Task<List<Branch>> GetQuerySetFour(string propName, string propName2, string propName3, string propName4, [FromBody] GenericObject T, string selectedOperator, string selectedOperator2, string selectedOperator3, string selectedOperator4)
        {
            var GrabStatement = GenerateClause4(propName, propName2, propName3, propName4, selectedOperator, selectedOperator2, selectedOperator3, selectedOperator4, T);
            return GrabStatement.ToList();

        }

        [HttpPost]
        [Route("GetTSet2")]
        public async Task<List<Branch>> GetQuerySetTwo(string propName, string propName2, [FromBody] GenericObject T, string selectedOperator, string selectedOperator2)
        {
            string columnName = T.columnName;
            var parameterValue = T.parameterValue;
            var GrabStatement = GenerateClause2(propName, propName2, selectedOperator, selectedOperator2, T);
            return GrabStatement.ToList();
        }

        public static Expression<Func<TItem, bool>> PropertyEquals1<TItem, TValue>(PropertyInfo propName, string selectedOperator, string propNameString, object fieldValue, GenericObject T)
        {
            bool where;
            Type myType = typeof(Branch);
            var PropertyInfo = myType.GetProperty(propNameString);

            var parameter = Expression.Parameter(typeof(Branch));
            var idproperty = myType.GetProperty(propNameString);
            MethodInfo contains = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            MethodInfo startsWith = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            PropertyDescriptor prop = GetProperty(props, propNameString, true);
            body = null;
            object x = ParseString(T.paramaterValue1);
            if (T.paramaterValue1 != null)
            {
                if (typeof(int) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValueInt = Convert.ToInt32(T.paramaterValue1);

                }
                if (typeof(string) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValue = T.paramaterValue1;
                }

                if (typeof(DateTime) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValueDateTime = Convert.ToDateTime(T.paramaterValue1);

                }
                if (selectedOperator == "contains")
                {
                    if (propName.PropertyType == typeof(int))
                    {
                        bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((T.parameterValueInt4)));
                    }
                    if (propName.PropertyType == typeof(DateTime))
                    {
                        bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((T.parameterValueDateTime4, typeof(DateTime?))));
                    }
                    if (propName.PropertyType == typeof(string))
                    {
                        bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((string)(T.parameterValue4)));
                    }
                    else
                    {
                        bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(Convert.ToString(T.parameterValueUndeclared)));

                    }
                }

                if (T != null)   // if the property is null and the object recieved is null we are going to write the appropriate expression and return it
                {
                    if (!string.IsNullOrWhiteSpace(T.parameterValue))
                    {
                        switch (selectedOperator)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = typeof(T).GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Equal(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }

                                body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                xs = typeof(T).GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.NotEqual(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                xs = typeof(T).GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.LessThan(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                xs = typeof(T).GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                xs = typeof(T).GetProperty(propNameString);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                }
                                body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThanOrEquals":
                                xs = typeof(T).GetProperty(propNameString);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right);
                                }
                                body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                xs = typeof(T).GetProperty(propNameString);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }



                                }

                                var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValue));
                                return Expression.Lambda<Func<TItem, bool>>(bodyLike, parameter);
                            case "StartsWith":
                                xs = typeof(T).GetProperty(propNameString);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName), startsWith, Expression.Constant(T.parameterValue));
                                return Expression.Lambda<Func<TItem, bool>>(bodyLike, parameter);
                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }
                    if (T.parameterValueInt >= 0)
                    {
                        switch (selectedOperator)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter tSype node and return the equals exprsession set to the constant object and property type
                                var xs =myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = myType.GetProperty(propNameString);

                                    var propertyInfo2 = myType.GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Equal(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Equal(Expression.Property(parameter, (propName)), Expression.Convert(Expression.Constant(T.parameterValueInt), typeof(int)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.NotEqual(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                xs = myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.LessThan(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Equal(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                xs = myType.GetProperty(propNameString);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }

                                }
                                var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValueInt, typeof(int)));
                                return Expression.Lambda<Func<TItem, bool>>(bodyLike, parameter);
                            case "StartsWith":
                                xs = myType.GetProperty(propNameString);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }



                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName), startsWith, Expression.Constant(T.parameterValue, typeof(int)));
                                return Expression.Lambda<Func<TItem, bool>>(bodyLike, parameter);

                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }
                    if (T.parameterValueDateTime >= DateTime.MinValue)
                    {
                        switch (selectedOperator)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    var bodytest = Expression.Equal(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(bodytest, parameter);
                                }
                                body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    var bodytest = Expression.NotEqual(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(bodytest, parameter);
                                }
                                body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                xs = myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    var bodytest = Expression.LessThan(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(bodytest, parameter);
                                }
                                body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    var bodytest = Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(bodytest, parameter);
                                }
                                body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    var bodytest = Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(bodytest, parameter);
                                }
                                body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThanOrEquals":

                                xs = myType.GetProperty(propNameString);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    var bodytest = Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                    return Expression.Lambda<Func<TItem, bool>>(bodytest, parameter);
                                }
                                body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                xs = myType.GetProperty(propNameString);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                }
                                var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                                return Expression.Lambda<Func<TItem, bool>>(bodyLike, parameter);
                            case "StartsWith":
                                xs = myType.GetProperty(propNameString);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }

                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName), startsWith, Expression.Constant(T.parameterValue, typeof(DateTime?)));
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
            }
            throw new Exception("Code failed");
        }
        public static Expression<Func<TItem, bool>> PropertyEquals2<TItem, TValue>(PropertyInfo propName, PropertyInfo propName2, string selectedOperator, string selectedOperator2, object value, object value2, GenericObject T, string propNameString, string propNameString2)
        {

            Type myType = typeof(Branch);
            var PropertyInfo = myType.GetProperty(propNameString);

            var parameter = Expression.Parameter(typeof(Branch));
            MethodInfo contains = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            MethodInfo StartsWith = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });

            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            if (T.paramaterValue1 != null)
            {
                if (typeof(int) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValueInt = Convert.ToInt32(T.paramaterValue1);

                }
                if (typeof(string) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValue = T.paramaterValue1;
                }

                if (typeof(DateTime) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValueDateTime = Convert.ToDateTime(T.paramaterValue1);

                }
            }
            if (T.paramaterValue2 != null)
            {
                if (typeof(int) == ParseString(T.paramaterValue2).GetType())
                {
                    T.parameterValueInt2 = Convert.ToInt32(T.paramaterValue2);

                }
                if (typeof(string) == ParseString(T.paramaterValue2).GetType())
                {
                    T.parameterValue2 = T.paramaterValue2;
                }

                if (typeof(DateTime) == ParseString(T.paramaterValue2).GetType())
                {
                    T.parameterValueDateTime2 = Convert.ToDateTime(T.paramaterValue2);

                }
            }

            body = null;
            if (selectedOperator == "contains")
            {
                if (propName2.PropertyType == typeof(int))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((T.parameterValueInt4)));
                }
                if (propName2.PropertyType == typeof(DateTime))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((T.parameterValueDateTime4, typeof(DateTime?))));
                }
                if (propName2.PropertyType == typeof(string))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((string)(T.parameterValue4)));
                }
                else
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(Convert.ToString(T.parameterValueUndeclared)));

                }
            }

            if (T != null)   // if the property is null and the object recieved is null we are going to write the appropriate expression and return it
            {
                if (!string.IsNullOrWhiteSpace(T.parameterValue))
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            var xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.Equal(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "NotEqual":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.NotEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "LessThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "LessThanOrEqual":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "GreaterThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "GreaterThanOrEquals":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "Like":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                if (body != null)
                                {
                                    body = Expression.Or(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;

                                }

                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValue));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                            }
                            break;
                        case "StartsWith":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                if (body != null)
                                {
                                    body = Expression.Or(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;

                                }



                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(T.parameterValue));

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
                if (T.parameterValueInt != null)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            var xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.Equal(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "NotEqual":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.NotEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "LessThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "LessThanOrEqual":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "GreaterThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "GreaterThanOrEquals":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "Like":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                if (body != null)
                                {
                                    body = Expression.And(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;

                                }

                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValueInt, typeof(int?)));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        case "StartsWith":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                if (body != null)
                                {
                                    body = Expression.And(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;

                                }

                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(T.parameterValueInt, typeof(int?)));

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
                if (T.parameterValueDateTime >= DateTime.MinValue)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            var xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.Equal(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }

                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "NotEqual":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.NotEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThanOrEqual":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThanOrEquals":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "Like":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                if (body != null)
                                {
                                    body = Expression.And(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;
                                }

                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body = Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        case "StartsWith":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                if (body != null)
                                {
                                    body = Expression.And(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;

                                }

                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body = Expression.And(bodyLike, bodyLike);

                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (T.Or == false)
                {
                    if (!string.IsNullOrWhiteSpace(T.parameterValue2))
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }

                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constssssssssant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), right));

                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValue2));

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
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }

                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValue2));

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

                    if (T.parameterValueInt2 != null)
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueInt2, typeof(int?)));

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
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueInt2, typeof(int?)));

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
                else
                {
                    if (T.parameterValueDateTime2 >= DateTime.MinValue)
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThanOrEqual(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right)));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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

                    if (T.parameterValueInt2 != null)
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThanOrEquals":
                                xs = typeof(T).GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueInt2, typeof(int?)));

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
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueInt2, typeof(int?)));

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
                    if (T.parameterValueDateTime2 >= DateTime.MinValue)
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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

                    if (!string.IsNullOrWhiteSpace(T.parameterValue2))
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValue2));

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
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValue2));

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
                }
            }
            throw new Exception("Not implement Operation");

        }
        public static object ParseString(string str)
        {

            bool boolValue;
            Int32 intValue;
            Int64 bigintValue;
            double doubleValue;
            DateTime dateValue;
            System.String stringValue;
            // Place checks higher in if-else statement to give higher priority to type.

            if (bool.TryParse(str, out boolValue))
                return boolValue;
            else if (Int32.TryParse(str, out intValue))
                return intValue;
            else if (Int64.TryParse(str, out bigintValue))
                return bigintValue;
            else if (double.TryParse(str, out doubleValue))
                return doubleValue;
            else if (DateTime.TryParse(str, out dateValue))
                return dateValue;
            else return str;

        }
        public static Expression<Func<TItem, bool>> PropertyEquals3<TItem, TValue>(PropertyInfo propName, PropertyInfo propName2, PropertyInfo propName3, string selectedOperator, string selectedOperator2, string selectedOperator3, GenericObject T, string propNameString, string propNameString2, string propNameString3)
        {
            Type myType = typeof(Branch);
            var PropertyInfo = myType.GetProperty(propNameString);

            var parameter = Expression.Parameter(typeof(Branch));
            MethodInfo contains = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            MethodInfo StartsWith = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });

            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            //PropertyDescriptor prop = GetProperty(props, T.parameterValue, true);
            if (T.paramaterValue1 != null)
            {
                if (typeof(int) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValueInt = Convert.ToInt32(T.paramaterValue1);

                }
                if (typeof(string) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValue = T.paramaterValue1;
                }

                if (typeof(DateTime) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValueDateTime = Convert.ToDateTime(T.paramaterValue1);

                }
            }
            if (T.paramaterValue2 != null)
            {
                if (typeof(int) == ParseString(T.paramaterValue2).GetType())
                {
                    T.parameterValueInt2 = Convert.ToInt32(T.paramaterValue2);

                }
                if (typeof(string) == ParseString(T.paramaterValue2).GetType())
                {
                    T.parameterValue2 = T.paramaterValue2;
                }

                if (typeof(DateTime) == ParseString(T.paramaterValue2).GetType())
                {
                    T.parameterValueDateTime2 = Convert.ToDateTime(T.paramaterValue2);

                }
            }
            if (T.paramaterValue3 != null)
            {
                if (typeof(int) == ParseString(T.paramaterValue3).GetType())
                {
                    T.parameterValueInt3 = Convert.ToInt32(T.paramaterValue3);

                }
                if (typeof(string) == ParseString(T.paramaterValue3).GetType())
                {
                    T.parameterValue3 = T.paramaterValue3;
                }

                if (typeof(DateTime) == ParseString(T.paramaterValue3).GetType())
                {
                    T.parameterValueDateTime3 = Convert.ToDateTime(T.paramaterValue3);

                }
            }
            if (T.paramaterValue4 != null)
            {
                if (typeof(int) == ParseString(T.paramaterValue4).GetType())
                {
                    T.parameterValueInt4 = Convert.ToInt32(T.paramaterValue4);

                }
                if (typeof(string) == ParseString(T.paramaterValue4).GetType())
                {
                    T.parameterValue4 = T.paramaterValue4;
                }

                if (typeof(DateTime) == ParseString(T.paramaterValue4).GetType())
                {
                    T.parameterValueDateTime4 = Convert.ToDateTime(T.paramaterValue4);

                }
            }
            body = null;
            if (selectedOperator == "contains")
            {
                if (propName2.PropertyType == typeof(int))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((T.parameterValueInt4)));
                }
                if (propName2.PropertyType == typeof(DateTime))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((T.parameterValueDateTime4, typeof(DateTime?))));
                }
                if (propName2.PropertyType == typeof(string))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((string)(T.parameterValue4)));
                }
                else
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(Convert.ToString(T.parameterValueUndeclared)));

                }
            }


            if (T != null)   // if the property is null and the object recieved is null we are going to write the appropriate expression and return it
            {
                if (!string.IsNullOrWhiteSpace(T.parameterValue))
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            var xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.Equal(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "NotEqual":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.NotEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "LessThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "LessThanOrEqual":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "GreaterThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "GreaterThanOrEquals":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "Like":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                if (body != null)
                                {
                                    body = Expression.Or(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;

                                }

                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValue));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                             Expression.And(bodyLike, bodyLike);
                            }
                            break;
                        case "StartsWith":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValue, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                if (body != null)
                                {
                                    body = Expression.Or(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;

                                }



                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(T.parameterValue));

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
                if (T.parameterValueInt >= null)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            var xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.Equal(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "NotEqual":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.NotEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "LessThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "LessThanOrEqual":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "GreaterThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "GreaterThanOrEquals":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int?)));
                            break;
                        case "Like":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                if (body != null)
                                {
                                    body = Expression.And(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;

                                }

                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValueInt, typeof(int?)));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        case "StartsWith":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueInt, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                if (body != null)
                                {
                                    body = Expression.And(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;

                                }

                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(T.parameterValueInt, typeof(int?)));

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
                if (T.parameterValueDateTime >= DateTime.MinValue)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            var xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.Equal(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }

                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "NotEqual":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.NotEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThanOrEqual":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThan":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThanOrEquals":
                            xs = myType.GetProperty(propNameString);
                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right);
                                break;
                            }
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "Like":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                if (body != null)
                                {
                                    body = Expression.And(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;
                                }

                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body = Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        case "StartsWith":
                            xs = myType.GetProperty(propNameString);

                            if (xs != null)
                            {
                                Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                //xs.SetValue(t, safeValue, null);
                                var propertyInfo = typeof(T).GetProperty(propNameString);

                                var propertyInfo2 = typeof(T).GetProperty(propNameString);
                                //however we can change what the constant is
                                var right = Expression.Constant(T.parameterValueDateTime, xs.PropertyType);
                                // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                if (body != null)
                                {
                                    body = Expression.And(Ts1Controller.bodyLike, body);
                                    break;

                                }
                                else
                                {
                                    body =
                                 Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                    break;

                                }

                            }
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));

                            if (body != null)
                            {
                                body = Expression.And(bodyLike, body);

                            }
                            else
                            {
                                body = Expression.And(bodyLike, bodyLike);

                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (T.Or == false)
                {
                    if (!string.IsNullOrWhiteSpace(T.parameterValue2))
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }

                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constssssssssant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), right));

                                    break;
                                }
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                    break;
                                }
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                    break;
                                }
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValue2));

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
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }

                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValue2));

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


                    if (T.parameterValueDateTime2 >= DateTime.MinValue)
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThanOrEqual(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right)));
                                    break;
                                }
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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

                    if (T.parameterValueInt2 != null)
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueInt2, typeof(int?)));

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
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueInt2, typeof(int?)));

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
                else
                {
                    if (T.parameterValueDateTime2 >= DateTime.MinValue)
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThanOrEqual(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right)));
                                    break;
                                }
                                body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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
                            case "StartsWith":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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

                    if (T.parameterValueInt2 != null)
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString2);


                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueInt2, typeof(int?)));

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
                            case "StartsWith":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueInt2, typeof(int?)));

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
                    if (T.parameterValueDateTime2 >= DateTime.MinValue)
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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
                            case "StartsWith":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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

                    if (!string.IsNullOrWhiteSpace(T.parameterValue2))
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString2);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    break;
                                }
                                body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValue2));

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

                            case "StartsWith":
                                xs = myType.GetProperty(propNameString2);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue2, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        break;

                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        break;
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValue2));

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
                }

                if (T.Or2 == false)
                {
                    if (!string.IsNullOrWhiteSpace(T.parameterValue3))
                    {
                        switch (selectedOperator3)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(Ts1Controller.body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(Ts1Controller.body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);

                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(Ts1Controller.body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(Ts1Controller.body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(Ts1Controller.body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(Ts1Controller.body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValue3));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body); return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);

                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike); return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);

                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                            case "StartsWith":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValue3));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body); return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);

                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike); return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);

                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);

                                }
                                break;

                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }

                    if (T.parameterValueDateTime3 >= DateTime.MinValue)
                    {
                        switch (selectedOperator3)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueDateTime3));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                            case "StartsWith":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime3));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                break;

                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(T.parameterValue3))
                    {
                        switch (selectedOperator3)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValue3));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                            case "StartsWith":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValue3));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                break;

                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }

                    if (T.parameterValueInt3 != null)
                    {
                        switch (selectedOperator3)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString2);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueInt3, typeof(int)));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }

                            case "StartsWith":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.And(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.And(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueInt3, typeof(int?)));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }


                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }

                    }
                }
                else
                {
                    if (T.parameterValueInt3 != null)
                    {
                        switch (selectedOperator3)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Convert(Expression.Constant(T.parameterValueInt3), typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueInt3, typeof(int)));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.Or(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }

                            case "StartsWith":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueInt3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);
                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueInt3, typeof(int?)));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.Or(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }


                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }
                    if (T.parameterValue3 != null)
                    {
                        switch (selectedOperator3)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValue3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValue3));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.Or(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }

                            case "StartsWith":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValue3, typeof(int?)));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.Or(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }


                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }
                    if (T.parameterValueDateTime3 >= DateTime.MinValue)

                    {
                        switch (selectedOperator3)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                var xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "NotEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "LessThanOrEqual":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThan":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "GreaterThanOrEquals":
                                xs = myType.GetProperty(propNameString3);
                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propertyInfo), right));
                                    return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                }
                                body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                break;
                            case "Like":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString2);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName3), contains, Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?)));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.Or(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }


                            case "StartsWith":
                                xs = myType.GetProperty(propNameString3);

                                if (xs != null)
                                {
                                    Type t = Nullable.GetUnderlyingType(xs.PropertyType);
                                    //xs.SetValue(t, safeValue, null);
                                    var propertyInfo = typeof(T).GetProperty(propNameString3);

                                    var propertyInfo2 = typeof(T).GetProperty(propNameString3);
                                    //however we can change what the constant is
                                    var right = Expression.Constant(T.parameterValueDateTime3, xs.PropertyType);
                                    // we cant change the value of the propertyInfo that keeps our variables in reflection with entity 
                                    Ts1Controller.bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, right);

                                    if (body != null)
                                    {
                                        body = Expression.Or(Ts1Controller.bodyLike, body);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                    else
                                    {
                                        body =
                                     Expression.Or(Ts1Controller.bodyLike, Ts1Controller.bodyLike);
                                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                                    }
                                }
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?)));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.Or(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                    break;
                                }
                                break;

                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }

                    }
                }
            }
            throw new Exception("");

        }


        public static Expression<Func<TItem, bool>> PropertyEquals4<TItem, TValue>(PropertyInfo propName, PropertyInfo propName2, PropertyInfo propName3, PropertyInfo propName4, string selectedOperator, string selectedOperator2, string selectedOperator3, string selectedOperator4, GenericObject T)
        {

            var parameter = Expression.Parameter(typeof(T)); var expressionParameter = GetMemberExpression<T>(parameter, propName.Name);
            MethodInfo contains = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            MethodInfo StartsWith = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });

            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            //PropertyDescriptor prop = GetProperty(props, T.parameterValue, true);
            if (T.paramaterValue1 != null)
            {
                if (typeof(int) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValueInt = Convert.ToInt32(T.paramaterValue1);

                }
                if (typeof(string) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValue = T.paramaterValue1;
                }

                if (typeof(DateTime) == ParseString(T.paramaterValue1).GetType())
                {
                    T.parameterValueDateTime = Convert.ToDateTime(T.paramaterValue1);

                }
            }
            if (T.paramaterValue2 != null)
            {
                if (typeof(int) == ParseString(T.paramaterValue2).GetType())
                {
                    T.parameterValueInt2 = Convert.ToInt32(T.paramaterValue2);

                }
                if (typeof(string) == ParseString(T.paramaterValue2).GetType())
                {
                    T.parameterValue2 = T.paramaterValue2;
                }

                if (typeof(DateTime) == ParseString(T.paramaterValue2).GetType())
                {
                    T.parameterValueDateTime2 = Convert.ToDateTime(T.paramaterValue2);

                }
            }
            if (T.paramaterValue3 != null)
            {
                if (typeof(int) == ParseString(T.paramaterValue3).GetType())
                {
                    T.parameterValueInt3 = Convert.ToInt32(T.paramaterValue3);

                }
                if (typeof(string) == ParseString(T.paramaterValue3).GetType())
                {
                    T.parameterValue3 = T.paramaterValue3;
                }

                if (typeof(DateTime) == ParseString(T.paramaterValue3).GetType())
                {
                    T.parameterValueDateTime3 = Convert.ToDateTime(T.paramaterValue3);

                }
            }
            if (T.paramaterValue4 != null)
            {
                if (typeof(int) == ParseString(T.paramaterValue4).GetType())
                {
                    T.parameterValueInt4 = Convert.ToInt32(T.paramaterValue4);

                }
                if (typeof(string) == ParseString(T.paramaterValue4).GetType())
                {
                    T.parameterValue4 = T.paramaterValue4;
                }

                if (typeof(DateTime) == ParseString(T.paramaterValue4).GetType())
                {
                    T.parameterValueDateTime4 = Convert.ToDateTime(T.paramaterValue4);

                }
            }
            body = null;
            if (selectedOperator == "contains")
            {
                if (propName2.PropertyType == typeof(int))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((T.parameterValueInt4)));
                }
                if (propName2.PropertyType == typeof(DateTime))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((T.parameterValueDateTime4, typeof(DateTime?))));
                }
                if (propName2.PropertyType == typeof(string))
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant((string)(T.parameterValue4)));
                }
                else
                {
                    var bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(Convert.ToString(T.parameterValueUndeclared)));

                }
            }

            if (T != null)   // if the property is null and the object recieved is null we are going to write the appropriate expression and return it
            {
                if (!string.IsNullOrWhiteSpace(T.parameterValue))
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValue));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValue));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                            Expression.And(bodyLike, bodyLike);
                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(T.parameterValue));


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
                if (T.parameterValueInt != null)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int)));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int)));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int)));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt, typeof(int)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValueInt, typeof(int)));

                            if (body != null)
                                body = Expression.And(bodyLike, body);
                            else
                            {
                                body =
                              Expression.And(bodyLike, bodyLike);

                            }
                            break;
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(T.parameterValueInt, typeof(int)));

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
                if (T.parameterValueDateTime == DateTime.MinValue)
                {
                    switch (selectedOperator)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Equal(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "NotEqual":
                            body = Expression.NotEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThan":
                            body = Expression.LessThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.LessThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThan":
                            body = Expression.GreaterThan(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));

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
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), StartsWith, Expression.Constant(T.parameterValueDateTime, typeof(DateTime?)));

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
            if (T.Or == false)
            {
                if (!string.IsNullOrWhiteSpace(T.parameterValue2))
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                            break;
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                            break;
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                            break;
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                            break;
                        case "Like":

                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValue2));

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
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValue2));

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
                if (T.parameterValueInt2 != null)
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int))));
                            break;
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int))));
                            break;
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int))));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int))));
                            break;
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int))));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int))));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueInt2, typeof(int)));

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
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueInt2, typeof(int?)));

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

                if (T.parameterValueDateTime2 == DateTime.MinValue)
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                            break;
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                            break;
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                            break;
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

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
                    if (!string.IsNullOrWhiteSpace(T.parameterValue2))
                    {
                        switch (selectedOperator2)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "NotEqual":
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "LessThan":
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "LessThanOrEqual":
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "GreaterThan":
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "GreaterThanOrEquals":
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                                break;
                            case "Like":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValue));

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
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValue2));

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
            else
            {
                if (T.parameterValueInt2 != null)
                {
                    switch (selectedOperator2)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                            break;
                        case "NotEqual":
                            body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                            break;
                        case "LessThan":
                            body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                            break;
                        case "GreaterThan":
                            var stomach = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName), Expression.Constant(T.parameterValueInt2, typeof(int?))));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueInt2, typeof(int?)));

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
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueInt2, typeof(int?)));

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
            if (T.parameterValueDateTime2 == DateTime.MinValue)
            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(Ts1Controller.body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                        break;
                    case "NotEqual":
                        body = Expression.Or(Ts1Controller.body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                        break;
                    case "LessThan":
                        body = Expression.Or(Ts1Controller.body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                        break;
                    case "LessThanOrEqual":
                        body = Expression.Or(Ts1Controller.body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                        break;
                    case "GreaterThan":
                        body = Expression.Or(Ts1Controller.body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                        break;
                    case "GreaterThanOrEquals":
                        body = Expression.Or(Ts1Controller.body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?))));
                        break;
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                            break;
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.And(bodyLike, bodyLike);
                            break;
                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime2, typeof(DateTime?)));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                            break;
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.And(bodyLike, bodyLike);
                            break;
                        }
                        break;
                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }
            if (!string.IsNullOrWhiteSpace(T.parameterValue2))
            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(Ts1Controller.body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                        break;
                    case "NotEqual":
                        body = Expression.Or(Ts1Controller.body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                        break;
                    case "LessThan":
                        body = Expression.Or(Ts1Controller.body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                        break;
                    case "LessThanOrEqual":
                        body = Expression.Or(Ts1Controller.body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                        break;
                    case "GreaterThan":
                        body = Expression.Or(Ts1Controller.body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                        break;
                    case "GreaterThanOrEquals":
                        body = Expression.Or(Ts1Controller.body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValue2)));
                        break;
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValue2));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                            return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.And(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);

                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValue2));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                            break;
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.And(bodyLike, bodyLike);
                            break;
                        }
                        break;

                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }


            if (T.Or2 == false)
            {
                if (!string.IsNullOrWhiteSpace(T.parameterValue3))
                {
                    switch (selectedOperator3)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(Ts1Controller.body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "NotEqual":
                            body = Expression.And(Ts1Controller.body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "LessThan":
                            body = Expression.And(Ts1Controller.body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.And(Ts1Controller.body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "GreaterThan":
                            body = Expression.And(Ts1Controller.body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.And(Ts1Controller.body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName), contains, Expression.Constant(T.parameterValue3));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                break;
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValue3));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                break;
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (T.parameterValueDateTime3 == DateTime.MinValue)
                {
                    switch (selectedOperator3)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueDateTime3));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                break;
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime3));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                break;
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (!string.IsNullOrWhiteSpace(T.parameterValue3))
                {
                    switch (selectedOperator3)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValue3)));
                            break;
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueDateTime3));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                break;
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime3));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                break;
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                break;
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }

                    if (T.parameterValueInt3 != null)
                    {
                        switch (selectedOperator3)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int?))));
                                break;
                            case "NotEqual":
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int?))));
                                break;
                            case "LessThan":
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int?))));
                                break;
                            case "LessThanOrEqual":
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int?))));
                                break;
                            case "GreaterThan":
                                body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int?))));
                                break;
                            case "GreaterThanOrEquals":
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int?))));
                                break;
                            case "Like":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueInt3, typeof(int?)));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike);
                                    break;
                                }

                            case "StartsWith":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueInt3, typeof(int?)));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                    break;
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike);
                                    break;
                                }


                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }
                }
            }
            if (T.parameterValueInt3 != null)
            {
                switch (selectedOperator3)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int?))));
                        break;
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName3), Expression.Convert(Expression.Constant(T.parameterValueInt3), typeof(int?))));
                        break;
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int?))));
                        break;
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int?))));
                        break;
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int?))));
                        break;
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName3), Expression.Constant(T.parameterValueInt3, typeof(int?))));
                        break;
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueInt3, typeof(int?)));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                            break;
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.Or(bodyLike, bodyLike);
                            break;
                        }

                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueInt3, typeof(int?)));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                            break;
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.Or(bodyLike, bodyLike);
                            break;
                        }


                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }
            if (T.parameterValueDateTime3 == DateTime.MinValue)

            {
                switch (selectedOperator2)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName2), Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?))));
                        break;
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), contains, Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?)));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                            break;
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.Or(bodyLike, bodyLike);
                            break;
                        }


                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName2), StartsWith, Expression.Constant(T.parameterValueDateTime3, typeof(DateTime?)));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                            break;
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.Or(bodyLike, bodyLike);
                            break;
                        }
                        break;

                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }

            }





            if (T.Or3 == false)
            {
                if (!string.IsNullOrWhiteSpace(T.parameterValue4))
                {
                    switch (selectedOperator4)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(Ts1Controller.body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(Ts1Controller.body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(Ts1Controller.body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(Ts1Controller.body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(Ts1Controller.body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(Ts1Controller.body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(T.parameterValue4));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(T.parameterValue4));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (T.parameterValueDateTime4 == DateTime.MinValue)
                {
                    switch (selectedOperator4)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(T.parameterValueDateTime4));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(T.parameterValueDateTime4));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }
                }

                if (!string.IsNullOrWhiteSpace(T.parameterValue4))
                {
                    switch (selectedOperator4)
                    {
                        case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                            body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "NotEqual":
                            body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThan":
                            body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "LessThanOrEqual":
                            body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThan":
                            body = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "GreaterThanOrEquals":
                            body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValue4)));
                            return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                        case "Like":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(T.parameterValue4));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                        case "StartsWith":
                            bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(T.parameterValue4));

                            if (Ts1Controller.body != null)
                            {
                                Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                            else
                            {
                                Ts1Controller.body =
                             Expression.And(bodyLike, bodyLike);
                                return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                            }
                            break;

                        default: //if it is not a case we will not implement this particular operation 
                            throw new Exception("Not implement Operation");
                    }

                    if (T.parameterValueInt4 != null)
                    {
                        switch (selectedOperator4)
                        {
                            case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                                body = Expression.And(body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "NotEqual":
                                body = Expression.And(body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThan":
                                body = Expression.And(body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "LessThanOrEqual":
                                body = Expression.And(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "GreaterThan":
                                var stomach = Expression.And(body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(stomach, parameter);
                            case "GreaterThanOrEquals":
                                body = Expression.And(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueInt4, typeof(int?))));
                                return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                            case "Like":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(T.parameterValueInt4, typeof(int?)));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                }
                                break;
                            case "StartsWith":
                                bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(T.parameterValueInt4, typeof(int?)));

                                if (Ts1Controller.body != null)
                                {
                                    Ts1Controller.body = Expression.And(bodyLike, Ts1Controller.body);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                }
                                else
                                {
                                    Ts1Controller.body =
                                 Expression.And(bodyLike, bodyLike);
                                    return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                                }
                                break;

                            default: //if it is not a case we will not implement this particular operation 
                                throw new Exception("Not implement Operation");
                        }
                    }
                }
            }
            if (T.parameterValueInt4 != null)
            {
                switch (selectedOperator4)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueInt4, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Convert(Expression.Constant(T.parameterValueInt4), typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueInt4, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueInt4, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueInt4, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueInt4, typeof(int?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(T.parameterValueInt4, typeof(int?)));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                            return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                        }
                        break;
                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(T.parameterValueInt4, typeof(int?)));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                            return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                        }
                        break;

                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }
            }
            if (T.parameterValueDateTime4 == DateTime.MinValue)

            {
                switch (selectedOperator4)
                {
                    case "Equals": //if the case is operations equals we Expression tree for a parameter type node and return the equals exprsession set to the constant object and property type
                        body = Expression.Or(body, Expression.Equal(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "NotEqual":
                        body = Expression.Or(body, Expression.NotEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThan":
                        body = Expression.Or(body, Expression.LessThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "LessThanOrEqual":
                        body = Expression.Or(body, Expression.LessThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThan":
                        body = Expression.Or(body, Expression.GreaterThan(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "GreaterThanOrEquals":
                        body = Expression.Or(body, Expression.GreaterThanOrEqual(Expression.Property(parameter, propName4), Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?))));
                        return Expression.Lambda<Func<TItem, bool>>(body, parameter);
                    case "Like":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName4), contains, Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?)));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                            return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                        }
                        break;


                    case "StartsWith":
                        bodyLike = Expression.Call(Expression.Property(parameter, propName4), StartsWith, Expression.Constant(T.parameterValueDateTime4, typeof(DateTime?)));

                        if (Ts1Controller.body != null)
                        {
                            Ts1Controller.body = Expression.Or(bodyLike, Ts1Controller.body);
                            return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                        }
                        else
                        {
                            Ts1Controller.body =
                         Expression.Or(bodyLike, bodyLike);
                            return Expression.Lambda<Func<TItem, bool>>(Ts1Controller.body, parameter);
                        }
                        break;

                    default: //if it is not a case we will not implement this particular operation 
                        throw new Exception("Not implement Operation");
                }

            }

            throw new Exception("Not implement Operation");


        }



        [HttpGet]
        [Route("OnPageLoad")]
        public ActionResult OnPageLoad()
        {
            var branches = _onPageLoadHelper.GetBranches();
            var TTitles = _onPageLoadHelper.GetEmployeeTitles();
            var TStatuses = _onPageLoadHelper.GetClientStatuses();

            var onPageLoad = new
            {
                branches,
                TTitles,
                TStatuses
            };

            return Ok(onPageLoad);
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
        private IQueryable<T> GenerateEqualsStatement(Type myType, T T, string propName)
        {
            myType = typeof(T);
            var PropertyInfo = myType.GetProperty(propName);

            return Enumerable.Empty<T>().AsQueryable();

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