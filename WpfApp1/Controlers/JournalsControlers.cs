using System.Collections.Generic;
using System.Linq;
using WpfApp1.Models;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Controlers
{
    class JournalsControlers
    {
        public static List<Journals> mass;
        readonly static Core bd = new Core();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="discipline"></param>
        /// <param name="student"></param>
        /// <param name="nameGroup"></param>
        /// <param name="ocenka"></param>
        /// <returns></returns>
        public static bool AddRating(int discipline, int student, int nameGroup, int ocenka)
        {
            mass = bd.context.Journals.Where(x => x.IdStudent == student && x.IdSubject == discipline).ToList();
            
            if (mass.Count() == 0)
                {
                if (discipline != 0 && student != 0 && nameGroup != 0)
                {
                    Journals evalution = new Journals()
                    {
                        IdGroup = nameGroup,
                        IdStudent = student,
                        IdSubject = discipline,
                        Evaluation = ocenka,
                    };
                    bd.context.Journals.Add(evalution);
                    if (bd.context.SaveChanges()>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
