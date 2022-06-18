using System;
using System.Collections.Generic;

namespace Studioarianearaujo_ATV5.Models
{
    public class Solicitacoes
    {
          private static List<Atendimento> lista  = new List<Atendimento>();

        public  Solicitacoes(){
            
        }

        public static void Incluir(Atendimento a){
            lista.Add(a);
        }

        public static List<Atendimento> Listar(){
            return lista;
        }
        public static int Totalizar(){
           return lista.Count;
                
                     
                
        }   
    }
}