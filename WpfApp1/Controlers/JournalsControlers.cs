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
        public static Journals mass;
        readonly static Core bd = new Core();
        /// <summary>
        /// добавление оценок
        /// </summary>
        /// <param name="discipline"></param>
        /// <param name="student">студент</param>
        /// <param name="nameGroup"> группа </param>
        /// <param name="ocenka"> итоговая оценка </param>
        /// <returns></returns>
        public static bool AddRating(int discipline, int student, int nameGroup, int ocenka)
        {
            mass = bd.context.Journals.Where(x => x.IdStudent == student && x.IdSubject == discipline).FirstOrDefault();
            
            if (mass==null && ocenka != 0)
                {
                if (discipline != 0 && student != 0 && nameGroup != 0 )
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
            if (mass != null && ocenka != 0)
            {
                RemoveEvalution(ocenka, mass.IdJournal);
                return true;
            }
            else 
            {
                return false;
            }
           
        }
        /// <summary>
        /// Редатирование оценки
        /// </summary>
        /// <param name="ocenka"></param>
        /// <param name="idJournal"></param>
        /// <returns></returns>
        public static bool RemoveEvalution(int ocenka, int idJournal)
        {
            Journals ectiveElement = bd.context.Journals.Where(x => x.IdJournal == idJournal ).FirstOrDefault();
            ectiveElement.Evaluation = ocenka;
            if (bd.context.SaveChanges()>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
