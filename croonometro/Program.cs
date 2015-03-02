/*
 * Created by SharpDevelop.
 * User: buba
 * Date: 02/03/2015
 * Time: 02:54 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
namespace croonometro
{
	class Program
	{
		 static public void Tick(Object stateInfo)
      {
          Console.WriteLine("cronometro {0}", DateTime.Now.ToString("h:mm:ss"));
      }

      static void Main()
      {
      	Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow
            	;
          TimerCallback callback = new TimerCallback(Tick);

          Console.WriteLine("Creating timer: {0}\n", 
                             DateTime.Now.ToString("h:mm:ss"));

          // create a one second timer tick
          Timer stateTimer = new Timer(callback, null, 0, 1000);

          // loop here forever
          for (; ; ) { }
      }
	}}