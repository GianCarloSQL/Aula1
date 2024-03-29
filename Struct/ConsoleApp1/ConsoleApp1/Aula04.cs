﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Aula04
    {

        public int numero { get; set; }

        public void GetInformacoes<T>(List<T> lista) {
            
          lista.ForEach(i => Console.WriteLine(i));
        }

        public string GetImagem() {
            return @"                                                                                           #&&&%%(#%%%%*%%&%,                                                                                        
                                                                                           #%%#%*##/&(&%%#.                                                                                       
                                                                                           *@@@@@@@@@@@@@@@%                                                                                         
                                                                                          .%@@@@@@@@@@&@@@@@/                                                                                        
                                                                                          (&@@@@&&&&&&&&@@@@#                                                                                        
                                                                                           (@@&&&&&&&&&&&@@&                                                                                         
                                                                                           %@&&&&&&&&&&&&@@&.                                                                                        
                                                                                          *@&&&&&&&&&&&&&@@@/                                                                                        
                                                                                          #@&&&&&&&&&&&&&@@@#                                                                                        
                                                                                         .&@&&&&&&&&&&&&&&@@&                                                                                        
                                                                                         /@@&&&&&&&&&&&&&&@@@,                                                                                       
                                                                                         (@@&&&&&&&&&&&&&&@@@/                                                                                       
                                                                                         %@@&&&&&&&&&&&&&&@@@#                                                                                       
                                                                                        *@@&&&&&&&&&&&&&&&@@@&                                                                                       
                                                                                        %%%%%%%#(##%%%#((#%%&%#                                                                                      
                                                                                       *%%%%%%%((##%%%#((#%%%                                                                                      
                                                                                       (%%%%%%%((#%%%%%((#%%%&%.                                                                                     
                                                                                       #%%%%%%#((#%%%%%((#%%%&%/                                                                                     
                                                                                      ,%%%%%%%#((#%%%%%#(#%%%%                                                                                     
                                                                                      #%%%%%%%#((#%%%%%#(#%%%%&%                                                                                     
                                                                                      #%%%%%%%####%%%%%#(#%%%%&%*                                                                                    
                                                                                     ,%%%%%%%%#((#%%%%%#(#%%%%&%#                                                                                    
                                                                                     (%%%%%%%%#(##%%%%%##(#%%%&                                                                                    
                                                                                     #%%%%#%%/./##%%%%%#((#%%%&&%.                                                                                   
                                                                                    .%%%%#,,(/####,..,///(#%%%&&(/                                                                                   
                                                                                    (%%%%/*%* ,, (,.#*, . #,%(%&%#                                                                                   
                                                                                    #%%%#%%#(((#%%%%#(/*.#*%%*&%                                                                                   
                                                                                   .%%(/./#%%##(##%%#/.,(##%%%,&&%,                                                                                  
                                                                                   (%&%%&&&&&&&&&&&&&&((##,.*%&%#                                                                                  
                                                                                   #&@@@@@@&&@@&&&&&&&&@@@@@@&%%&                                                                                  
                                                                                   #@@@@@@@&@@@&&&&&@&&@@@@@@@@@@@%                                                                                  
                                                                                  /%@@@@@@@@&&@&&&&@@&@@@@@@@@@@@@@*                                                                                 
                                                                                  #@@@@@@@@&@&&&&&&@@&@@@@@@@@@@@@@(                                                                                 
                                                                                 /%@@@@@@@@&&&%&&@@@@@@@@@@@@@@@@@@@,                                                                                
                                                                                .(@@@@@@@@@&%%&&@@@@@@@@&&&@@@@@@@@@#                                                                                
                                                                               ,/&@@@@@@@&&%%%%&&&&&&&@@@&%%&@@@@@@@@(                                                                               
                                                                              *#@@@@@&&&&%%&&&&%&&&&&&&&&&%%&&@@@@@@@@@*                                                                             
                                                                            **&@@@&&&&&&&%&&&&%&&&&&&&&&&&%%%&&@@@@@@@@@(                                                                            
                                                                           /@&@&&&&&&&&&%&&&%%%%&&&&&&&&&&%%%%&&@@@@@@@@@@                                                                           
                                                                          .@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%&&@@@@@@@@@@@                                                                          
                                                                          .@&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&&&&&&@&@@@@@@@                                                                          
                                                                          .@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@@                                                                          
                                                                          .@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@@@                                                                          
                                                                           @&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@                                                                          
                                                                           @&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@                                                                          
                                                                           @&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@&@@@@@@%                                                                          
                                                                           &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@&&&&@@@@@(                                                                          
                                                                           %&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@&&&@@@&&&&&@@@@,                                                                          
                                                                           #@&@@@&&&&@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@.                                                                          
                                                                           #&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@&&&@&&&&@@@@                                                                           
                                                                           %&&%%%%%&&&&&&&&%&&&&&&&&&&&&&&&&&&&&%%%%%%%&&&                                                                           
                                                                           %&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&                                                                           
                                                                           #&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&                                                                           
                                                                           #&&%%%%%%%%%%#(*,.........  ..,*(#%%%%%%%%%&&&&                                                                           
                                                                           #&%**./,,. ... ..,,,,,*.*,,,*.,   .. .,** *%&&&                                                                           
                                                                           #&%%,.,,*.  .,,*....      .... ,, .. .*, ,,%&&&                                                                           
                                                                           (&%%,..,. ..*,.     .  ..        .,,.  ..,*%&&&                                                                           
                                                                           (&&%.,. ..*,.  ...          ....   ,,,  .,%&&&&                                                                           
                                                                           (&%%,.....*,..,..,.( *,./ (,*,......,. ..*./%&&                                                                           
                                                                           /#...,,,..,,....,,,.., . ,, ..,.........,....%&                                                                           
                                                                           /*,.,.. ,,,.,, ,,  ....,. ,, /., .....*.*,**.*%                                                                           
                                                                           /,..,,.   ,*.. ,..,..((,. .,, .. ...   ..../*,%                                                                           
                                                                           **..,... ....,...* .,......../.........  ....%#                                                                           
                                                                           *&,.,,.,**,* .. ..,.,.  ,..,,.. .. ....,**,.%&(                                                                           
                                                                           *&&%%%%%%%%%#(%*...,, ,,. .., .%%#%%%##%%%%%%&(                                                                           
                                                                           *&... .*(#%%##((%/. ,,*,,,..,%%##%#(*.  .....&/                                                                           
                                                                           *&.......             ...               .....&*                                                                           
                                                                           /%.(.. @ ,.%                           ......&,                                                                           
                                                                           ,%....&/ .@          &              /  ( (%.,&,                                                                           
                                                                           ,%...&(*.#* & ,% (* &  & & & & ,(, .*#(  (..,&.                                                                           
                                                                           .%..,.*&*& (/,& /& #(.& ( & ././ % (/. ...,&                                                                            
                                                                           .%......                                ....,&                                                                            
                                                                           .%.......  . ....   .. .  .,... .. ..   ....*&                                                                            
                                                                           .%.......                               ....*&                                                                            
                                                                           .%..,.....                          ........*&                                                                            
                                                                            %...,..,..                        ........./&                                                                            
                                                                            %%%(,..                               *#%%&&&                                                                            
                                                                            %&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&                                                                            
                                                                            %%%%%%%%%%%%%%###(%((%%(##%%#%#%###%%%%%%%&&&                                                                            
                                                                            %&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&                                                                            
                                                                            &@@@&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&@@@@@(                                                                            
                                                                            &@@@@@@@@&&&&&%%%&&&&&&&&&&&&&&&%%&&&&@@@@@@/                                                                            
                                                                            &@@@@@@&&&&&&&%%%&&&&&&&&&&&&&&%%%&&&&@@@@@@/                                                                            
                                                                            &@@@@@@@@&&&&&%%&&&&&&&&&&&&&&&&&&&&&&@@@@@@/                                                                            
                                                                           *@@@@@@@@@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@#                                                                            
                                                                           #@@@@@@@@@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@                                                                            
                                                                          ,&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&@@@@@@@@@@@@@@@&                                                                           
                                                                          (@@@@@@@@@@@@&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                                                           
                                                                          (@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                                                           
                                                                          #@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&@@@@@@@                                                                           
                                                                          #@@@@@@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@                                                                           
                                                                          (@@@@@@@&&&&&&&&%&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@&                                                                           
                                                                          .&@@@@@@&&&&@&&&%&&&&@@@@@@@@&&&&&&&&&&&&@@@@@@,                                                                           
                                                                           #@@@@@&@@@@@@@&&%&&@@@@@@@@@@@@&&&&&@&@&&@@@@@                                                                            
                                                                            #&&&&@@@@@@@@&&&&&&@@@@@@@@@@@&&&&@@@@@&&&&&                                                                             
                                                                             /%&&&@@@@@@@@@@@@&@@@@@@@@@@@@@@@@@@&@&&&.                                                                              
                                                                                (@&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&%                                                                                 ";
        }


        public static void PedeInformacao()
        {

            while (true)
            {
                Console.WriteLine("Digite a sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                if (ValidaIdade(idade))
                {
                    break;
                }
                if (idade >= 18)
                {
                    Console.WriteLine("Voce pode beber bebidas alcoolicas");
                }
                else
                {
                    Console.WriteLine("Voce nao pode beber bebidas alcoolicas");
                }



            }


        }
        public static bool ValidaIdade(int idade)
        {
            return (idade >= 99 || idade < 0) ? true : false;
        }



        public static void Exercicio07semArray()
        {
            Console.WriteLine("Informe o texto: ");
            string texto = Console.ReadLine();
            Console.WriteLine($"a: {texto.Split('a').Length - 1}\ne: {texto.Split('e').Length - 1}\n" +
                $"i: {texto.Split('i').Length - 1}\no: {texto.Split('o').Length - 1}\nu: {texto.Split('u').Length - 1}\n");
            Console.ReadKey();
        }

    }
}

