﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSharp.Extension.DataTypes
{
    public static class ListExtension
    {
        public static double ToNumber(this List<object> list)
        {
            return list.Count;
        }

        public static string ToText(this List<object> list)
        {
            var strList = from item in list select item.ToText();

            return "[" + string.Join(", ", strList) + "]";
        }

        public static bool ToBool(this List<object> list)
        {
            return list != null && list.Any();
        }

        public static object ToCustom(this List<object> list)
        {
            return null;
        }

        public static List<object> ToList(this List<object> list)
        {
            return list;
        }
        
        #region list, string 비교
        // 이미 StringExtension에 정의됨
        public static bool IsEqualThan(this List<object> target1, string target2)
        {
            return target2.IsEqualThan(target1);
        }

        public static bool IsNotEqualThan(this List<object> target1, string target2)
        {
            return target2.IsNotEqualThan(target1);
        }

        public static bool IsLessEqualThan(this List<object> target1, string target2)
        {
            return target2.IsLessEqualThan(target1);
        }

        public static bool IsGreaterEqualThan(this List<object> target1, string target2)
        {
            return target2.IsGreaterEqualThan(target1);
        }

        public static bool IsLessThan(this List<object> target1, string target2)
        {
            return target2.IsLessThan(target1);
        }

        public static bool IsGreaterThan(this List<object> target1, string target2)
        {
            return target2.IsGreaterThan(target1);
        }
        #endregion

        #region list, bool 비교
        // 이미 BoolExtension에 정의됨
        public static bool IsEqualThan(this List<object> target1, bool target2)
        {
            return target2.IsEqualThan(target1);
        }

        public static bool IsNotEqualThan(this List<object> target1, bool target2)
        {
            return target2.IsNotEqualThan(target1);
        }

        public static bool IsLessEqualThan(this List<object> target1, bool target2)
        {
            return target2.IsLessEqualThan(target1);
        }

        public static bool IsGreaterEqualThan(this List<object> target1, bool target2)
        {
            return target2.IsGreaterEqualThan(target1);
        }

        public static bool IsLessThan(this List<object> target1, bool target2)
        {
            return target2.IsLessThan(target1);
        }

        public static bool IsGreaterThan(this List<object> target1, bool target2)
        {
            return target2.IsGreaterThan(target1);
        }
        #endregion

        #region list, number 비교
        // 이미 NumberExtension에 정의됨
        public static bool IsEqualThan(this List<object> target1, double target2)
        {
            return target2.IsEqualThan(target1);
        }

        public static bool IsNotEqualThan(this List<object> target1, double target2)
        {
            return target2.IsNotEqualThan(target1);
        }

        public static bool IsLessEqualThan(this List<object> target1, double target2)
        {
            return target2.IsLessEqualThan(target1);
        }

        public static bool IsGreaterEqualThan(this List<object> target1, double target2)
        {
            return target2.IsGreaterEqualThan(target1);
        }

        public static bool IsLessThan(this List<object> target1, double target2)
        {
            return target2.IsLessThan(target1);
        }

        public static bool IsGreaterThan(this List<object> target1, double target2)
        {
            return target2.IsGreaterThan(target1);
        }
        #endregion

        #region list, list 비교
        public static bool IsEqualThan(this List<object> target1, List<object> target2)
        {
            var cnt = target1.Count;
            if (cnt != target2.Count)
            {
                return false;
            }

            for(int i=0; i<cnt; i++)
            {
                if (!target1.IsEqualThan(target2))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsNotEqualThan(this List<object> target1, List<object> target2)
        {
            var cnt = target1.Count;
            if (cnt != target2.Count)
            {
                return true;
            }

            for (int i = 0; i < cnt; i++)
            {
                if (!target1.IsEqualThan(target2))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsLessEqualThan(this List<object> target1, List<object> target2)
        {
            return target1.IsEqualThan(target2);
        }

        public static bool IsGreaterEqualThan(this List<object> target1, List<object> target2)
        {
            return target1.IsEqualThan(target2);
        }

        public static bool IsLessThan(this List<object> target1, List<object> target2)
        {
            return target1.IsNotEqualThan(target2);
        }

        public static bool IsGreaterThan(this List<object> target1, List<object> target2)
        {
            return target1.IsNotEqualThan(target2);
        }
        #endregion

        #region list, object 비교
        public static bool IsEqualThan(this List<object> target1, object target2)
        {
            if (target2 is double)
            {
                return target1.IsEqualThan((double)target2);
            }
            else if (target2 is string)
            {
                return target1.IsEqualThan((string)target2);
            }
            else if (target2 is bool)
            {
                return target1.IsEqualThan((bool)target2);
            }
            else if (target2 is List<object>)
            {
                return target1.IsEqualThan(target2 as List<object>);
            }
            else
            {
                return target1 == target2;
            }
        }

        public static bool IsNotEqualThan(this List<object> target1, object target2)
        {
            if (target2 is double)
            {
                return target1.IsNotEqualThan((double)target2);
            }
            else if (target2 is string)
            {
                return target1.IsNotEqualThan((string)target2);
            }
            else if (target2 is bool)
            {
                return target1.IsNotEqualThan((bool)target2);
            }
            else if (target2 is List<object>)
            {
                return target1.IsNotEqualThan(target2 as List<object>);
            }
            else
            {
                return target1 != target2;
            }
        }

        public static bool IsLessEqualThan(this List<object> target1, object target2)
        {
            if (target2 is double)
            {
                return target1.IsLessEqualThan((double)target2);
            }
            else if (target2 is string)
            {
                return target1.IsLessEqualThan((string)target2);
            }
            else if (target2 is bool)
            {
                return target1.IsLessEqualThan((bool)target2);
            }
            else if (target2 is List<object>)
            {
                return target1.IsLessEqualThan(target2 as List<object>);
            }
            else
            {
                return target1 == target2;
            }
        }

        public static bool IsGreaterEqualThan(this List<object> target1, object target2)
        {
            if (target2 is double)
            {
                return target1.IsGreaterEqualThan((double)target2);
            }
            else if (target2 is string)
            {
                return target1.IsGreaterEqualThan((string)target2);
            }
            else if (target2 is bool)
            {
                return target1.IsGreaterEqualThan((bool)target2);
            }
            else if (target2 is List<object>)
            {
                return target1.IsGreaterEqualThan(target2 as List<object>);
            }
            else
            {
                return target1 == target2;
            }
        }

        public static bool IsLessThan(this List<object> target1, object target2)
        {
            if (target2 is double)
            {
                return target1.IsLessThan((double)target2);
            }
            else if (target2 is string)
            {
                return target1.IsLessThan((string)target2);
            }
            else if (target2 is bool)
            {
                return target1.IsLessThan((bool)target2);
            }
            else if (target2 is List<object>)
            {
                return target1.IsLessThan(target2 as List<object>);
            }
            else
            {
                return target1 != target2;
            }
        }

        public static bool IsGreaterThan(this List<object> target1, object target2)
        {
            if (target2 is double)
            {
                return target1.IsGreaterThan((double)target2);
            }
            else if (target2 is string)
            {
                return target1.IsGreaterThan((string)target2);
            }
            else if (target2 is bool)
            {
                return target1.IsGreaterThan((bool)target2);
            }
            else if (target2 is List<object>)
            {
                return target1.IsGreaterThan(target2 as List<object>);
            }
            else
            {
                return target1 != target2;
            }
        }
        #endregion
    }
}
