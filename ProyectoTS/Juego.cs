﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTS
{
    public class Juego
    {
        public Jugador player1, player2;
        int cont1, cont2;
        int contMov = 0;
        public bool newTurn = true;
        public List<Territorio> territorios;
        public List<Movimiento> moves, auxMoves;
        

        /// <summary>
        /// Crea todos los territorios del mapa y llama para asignar los primeros
        /// </summary>
        public void Inicio()
        {
            player1 = new Jugador();
            player2 = new Jugador("IA");
            territorios = new List<Territorio>();
            moves = new List<Movimiento>();
            auxMoves = new List<Movimiento>();

            //Norteamerica
            territorios.Add(new Territorio("Alaska"));
            territorios.Add(new Territorio("Canada"));
            territorios.Add(new Territorio("Mexico"));
            territorios.Add(new Territorio("Groenlandia"));
            territorios.Add(new Territorio("USA este"));
            territorios.Add(new Territorio("USA oeste"));
            territorios.Add(new Territorio("Centroamerica"));
            //America del Sur
            territorios.Add(new Territorio("Argentina"));
            territorios.Add(new Territorio("Brasil"));
            territorios.Add(new Territorio("Venezuela"));
            //Africa
            territorios.Add(new Territorio("Africa del Norte"));
            territorios.Add(new Territorio("Egipto"));
            territorios.Add(new Territorio("Congo"));
            territorios.Add(new Territorio("Sudafrica"));
            //Europa
            territorios.Add(new Territorio("Inglaterra"));
            territorios.Add(new Territorio("Europa del Norte"));
            territorios.Add(new Territorio("Escandinavia"));
            territorios.Add(new Territorio("Europa del Sur"));
            territorios.Add(new Territorio("Ucrania"));
            territorios.Add(new Territorio("Europa Occidental"));
            //Oceania
            territorios.Add(new Territorio("Indonesia"));
            territorios.Add(new Territorio("Australia"));
            //Asia
            territorios.Add(new Territorio("Japon"));
            territorios.Add(new Territorio("India"));
            territorios.Add(new Territorio("Rusia"));
            territorios.Add(new Territorio("China"));
            territorios.Add(new Territorio("Siberia"));
            territorios.Add(new Territorio("Irak"));
            

            for (int i = 0; i < territorios.ToArray().Length; i++)
            {
                if (territorios.ToArray()[i].nombre == "Alaska")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Canada" || item.nombre == "Rusia")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if(territorios.ToArray()[i].nombre == "Canada")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "USA este" || item.nombre == "USA oeste" || item.nombre == "Groenlandia")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Mexico")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "USA oeste" || item.nombre == "Centroamerica")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Groenlandia")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Canada" || item.nombre == "Inglaterra")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "USA este")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "USA oeste" || item.nombre == "Canada")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "USA oeste")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "USA este" || item.nombre == "Canada" || item.nombre == "Mexico")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Centroamerica")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Mexico" || item.nombre == "Venezuela")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Argentina")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Brasil" || item.nombre == "Venezuela")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Brasil")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Argentina" || item.nombre == "Venezuela" || item.nombre == "Africa del Norte")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Venezuela")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Argentina" || item.nombre == "Brasil" || item.nombre == "Centroamerica")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Africa del Norte")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Brasil" || item.nombre == "Egipto" || item.nombre == "Congo" || item.nombre == "Europa Occidental")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Egipto")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Africa del Norte" || item.nombre == "Congo" || item.nombre == "Irak" || item.nombre == "Europa del Sur")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Congo")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Africa del Norte" || item.nombre == "Egipto" || item.nombre == "Sudafrica")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Sudafrica")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Congo")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Inglaterra")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Groenlandia" || item.nombre == "Escandinavia" || item.nombre == "Europa del Norte" || item.nombre == "Europa Occidental")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Europa del Norte")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Inglaterra" || item.nombre == "Ucrania" || item.nombre == "Europa del Sur")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Escandinavia")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Ucrania" || item.nombre == "Inglaterra")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Europa del Sur")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Egipto" || item.nombre == "Europa del Norte" || item.nombre == "Ucrania" || item.nombre == "Europa Occidental")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Ucrania")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Rusia" || item.nombre == "Irak" || item.nombre == "Escandinavia" || item.nombre == "Europa del Norte" || item.nombre == "Europa del Sur")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Europa Occidental")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Africa del Norte" || item.nombre == "Europa del Norte" || item.nombre == "Europa del Sur" || item.nombre == "Inglaterra")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Indonesia")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Australia" || item.nombre == "China" || item.nombre == "India")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Australia")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Indonesia")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Japon")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "China")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "India")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Irak" || item.nombre == "Siberia" || item.nombre == "China" || item.nombre == "Inglaterra")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Rusia")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Ucrania" || item.nombre == "Siberia" || item.nombre == "China" || item.nombre == "Alaska")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "China")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Siberia" || item.nombre == "Japon" || item.nombre == "Rusia" || item.nombre == "India" || item.nombre == "Inglaterra")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Siberia")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Rusia" || item.nombre == "Irak" || item.nombre == "India" || item.nombre == "China")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }
                else if (territorios.ToArray()[i].nombre == "Irak")
                {
                    foreach (Territorio item in territorios)
                    {
                        if (item.nombre == "Ucrania" || item.nombre == "Siberia" || item.nombre == "India" || item.nombre == "Egipto")
                        {
                            territorios.ToArray()[i].vecinos.Add(item);
                        }
                    }
                }

            }

            
            asignarTerritoriosIniciales();
            /*Luego de asignados los territorios iniciales al resto se le 
             colocan tropas de manera aleatoria*/
            Random obj = new Random();
            int ran = 0;
            for (int i = 0; i < territorios.ToArray().Length; i++)
            {
                ran = obj.Next(2, 4);
                if (!territorios.ToArray()[i].conquistado)
                {
                    territorios.ToArray()[i].tropas = ran;
                    territorios.ToArray()[i].auxTropas = ran;
                }
            }
        }

        /// <summary>
        /// Metodo para reiniciar el juego, guarda el nick que ya tenia el usuario
        /// </summary>
        public void Reiniciar()
        {
            string jugador = player1.nick;
            Inicio();
            player1.nick = jugador;
        }

        /// <summary>
        /// Asigna el territorio en el que va a empezar cada uno de los jugadores
        /// </summary>
        public void asignarTerritoriosIniciales()
        {
            Random obj = new Random();
            int opc1 = 10;
            int opc2 = 10;

            opc1 = obj.Next(1, 7);
            opc2 = obj.Next(1, 7);
            if (opc2 == opc1)
            {
                asignarTerritoriosIniciales();
            }

            primerosTerritorios(opc1, player1);
            primerosTerritorios(opc2, player2);
        }

        /// <summary>
        /// Metodo que devuelve un territorio especifico de la lista de territorios
        /// </summary>
        /// <param name="nom">Nombre del territorio</param>
        /// <returns></returns>
        public Territorio encontrarTerritorio(string nom)
        {
            foreach (Territorio item in territorios)
            {
                if (item.nombre == nom)
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// Asigna un nuevo amo a un terrotorio cuando es conquistado
        /// </summary>
        /// <param name="p">Jugador que conquista</param>
        /// <param name="l">Territorio conquistado</param>
        public void asignarAmo(Jugador p, Territorio l)
        {
            foreach (Territorio item in territorios)
            {
                if (item == l)
                {
                    if (item.conquistado)
                    {
                        item.amo.conquistados.Remove(l);
                    }
                    item.conquistado = true;
                    item.amo = p;
                    p.conquistados.Add(item);
                }
            }
        }

        /// <summary>
        /// Opcion para asignar el territorio inicial de forma aleatoria
        /// </summary>
        /// <param name="o">Opcion de territorio</param>
        /// <param name="P">Jugador a asignar</param>
        public void primerosTerritorios(int o, Jugador P)
        {
            if(o == 1)
            {
                P.conquistados.Add(encontrarTerritorio("Australia"));
                asignarAmo(P, encontrarTerritorio("Australia"));
            }
            else if (o == 2)
            {
                P.conquistados.Add(encontrarTerritorio("Argentina"));
                asignarAmo(P, encontrarTerritorio("Argentina"));
            }
            else if (o == 3)
            {
                P.conquistados.Add(encontrarTerritorio("Mexico"));
                asignarAmo(P, encontrarTerritorio("Mexico"));
            }
            else if (o == 4)
            {
                P.conquistados.Add(encontrarTerritorio("Congo"));
                asignarAmo(P, encontrarTerritorio("Congo"));
            }
            else if (o == 5)
            {
                P.conquistados.Add(encontrarTerritorio("Europa del Norte"));
                asignarAmo(P, encontrarTerritorio("Europa del Norte"));
            }
            else if (o == 6)
            {
                P.conquistados.Add(encontrarTerritorio("Japon"));
                asignarAmo(P, encontrarTerritorio("Japon"));
            }
        }

        /// <summary>
        /// Metodo para guardar un nuevo movimiento 
        /// </summary>
        /// <param name="player"></param>
        /// <param name="mov"></param>
        public void nuevoMovimiento(string player, Movimiento mov)
        {
            /*
             Si es una nueva ronda de turnos para ambos jugadores escoge al azar
             que jugador tendra el primer turno.
             */
            if (newTurn)
            {
                int k = 10;
                Random op = new Random();
                k = op.Next(0, 2);

                if (k == 0)
                {
                    cont1 = 0;
                    cont2 = 1;
                }
                else if (k == 1)
                {
                    cont1 = 1;
                    cont2 = 0;
                }
            }


            /*
             Valida que jugador está haciendo el movimiento para asignar el
             numero al mov. y agregarlo a la lista
             */
            if (player == player1.nick)
            {
                if (cont1 != 0 || cont1 != 1)
                {
                    cont1++;
                }
                mov.numMov = cont1;

            }
            else if (player == player2.nick)
            {
                if (cont2 != 0 || cont2 != 1)
                {
                    cont2++;
                }
                mov.numMov = cont2;
            }
            mov.territorio1.auxTropas -= mov.tropas;
            
            auxMoves.Add(mov);
            contMov++;
        }

        /// <summary>
        /// Metodo para los movimientos que son de asignar tropas porque estos
        /// se ejecutan de forma directa
        /// </summary>
        /// <param name="player">Nombre del jugador que lo realiza</param>
        /// <param name="mov">Movimiento</param>
        public void nuevoAsignar(string player, Movimiento mov)
        {
            mov.territorio1.tropas += mov.tropas;
            mov.territorio1.auxTropas = mov.territorio1.tropas; 
            moves.Add(mov);
        }


        /// <summary>
        /// Se ejecutan los movimientos guardados en la lista auxiliar de movs.
        /// </summary>
        public void EjecutarMovimientos()
        {
            foreach (Movimiento item in auxMoves)
            {
                if (item.descrip == "mover")
                {
                    item.territorio2.tropas += item.tropas;
                    item.territorio1.tropas -= item.tropas;


                }
                else if (item.descrip == "atacar")
                {
                    /*Si las tropas enviadas son mas que las que estan
                     * entonces el territorio cambia de amo*/
                    if (item.territorio2.tropas < item.tropas)
                    {
                        asignarAmo(item.jugador, item.territorio2);
                    }
                    item.territorio2.tropas = Math.Abs(item.territorio2.tropas - item.tropas);
                    item.territorio1.tropas -= item.tropas;
                }
                /*Por si no se etiqueta el movimiento valida si los amos
                 de los territorios son iguales y realiza los procedimientos
                 de arriba*/
                else
                {
                    if (validarConquistador(item.territorio1, item.territorio2))
                    {
                        item.descrip = "mover";
                        item.territorio2.tropas += item.tropas;
                        item.territorio1.tropas -= item.tropas;
                    }
                    else
                    {
                        item.descrip = "atacar";
                        if (item.territorio2.tropas < item.tropas)
                        {
                            asignarAmo(item.jugador, item.territorio2);
                        }
                        item.territorio2.tropas = Math.Abs(item.territorio2.tropas - item.tropas);
                        item.territorio1.tropas -= item.tropas;
                    }
                    
                }
                item.territorio1.auxTropas = item.territorio1.tropas;
                item.territorio2.auxTropas = item.territorio2.tropas;

                moves.Add(item);
            }

            auxMoves = new List<Movimiento>();
            darNuevasTropas(player1);
            darNuevasTropas(player2);
            newTurn = true;
        }

        /// <summary>
        /// Metodo para asignar las tropas para el nuevo turno
        /// </summary>
        /// <param name="p">Jugador al que se le va a dar</param>
        public void darNuevasTropas(Jugador p)
        {
            int pla1 = player1.conquistados.Count();
            int pla2 = player2.conquistados.Count();
            int dar = 0;
            dar = cantidadTropas(pla1);
            player1.tropas = dar;
            dar = cantidadTropas(pla2);
            player2.tropas = dar;
        }

        /// <summary>
        /// Metodo para validar cuantas tropas se le asigna al jugador
        /// para el nuevo turno segun sus territorios
        /// </summary>
        /// <param name="n">No. territorios conquistados</param>
        /// <returns>No. tropas a asignar</returns>
        public int cantidadTropas(int n)
        {
            int t = 0;
            if (n > 0 && n <= 7)
            {
                t = 5;
            }
            else if (n > 7 && n <= 14)
            {
                t = 10;
            }
            else if (n > 14 && n <= 21)
            {
                t = 15;
            }
            else if (n > 21 && n < 28)
            {
                t = 20;
            }
            return t;
        }

        /// <summary>
        /// Valida si dos territoios tienen el mismo amo o no
        /// </summary>
        /// <param name="t1">Territorio 1</param>
        /// <param name="t2">Territorio 2</param>
        /// <returns>Verdadero si comparten amo</returns>
        public bool validarConquistador(Territorio t1, Territorio t2)
        {
            if (t1.amo == t2.amo)
            {
                return true;
            }
            return false;
        }
    }
}
