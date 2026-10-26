using System;
namespace ProyectoMatematicoWinForms {
 public class JuegoLogica {
  readonly Random r=new Random(); public int Nivel{get;private set;} public int Puntaje{get;private set;} public int Vidas{get;private set;} public string Operacion{get;private set;} public int A{get;private set;} public int B{get;private set;} public int Correcta{get;private set;}
  public JuegoLogica(){Reiniciar();} public void Reiniciar(){Nivel=1;Puntaje=0;Vidas=3;Generar();}
  public void Generar(){Nivel=1+Puntaje/30; int max=10+Nivel*10; int tipo=r.Next(Math.Min(4,1+Nivel/2)); if(tipo==0){Operacion="+";A=r.Next(1,max+1);B=r.Next(1,max+1);Correcta=A+B;} else if(tipo==1){Operacion="-";A=r.Next(1,max+1);B=r.Next(1,max+1);if(B>A){int t=A;A=B;B=t;}Correcta=A-B;} else if(tipo==2){Operacion="×";A=r.Next(2,Math.Min(16,6+Nivel*2));B=r.Next(2,Math.Min(16,6+Nivel*2));Correcta=A*B;} else {Operacion="÷";B=r.Next(2,Math.Min(12,5+Nivel));Correcta=r.Next(2,Math.Min(12,5+Nivel));A=B*Correcta;}}
  public bool Comprobar(int respuesta){bool ok=respuesta==Correcta;if(ok)Puntaje+=10;else Vidas--;Generar();return ok;}
 }
}
