using System; using System.Drawing; using System.Windows.Forms;
namespace ProyectoMatematicoWinForms {
 public class InicioForm:Form { TextBox p1,p2; RadioButton individual,dos; Button iniciar;
  public InicioForm(){Text="Proyecto Matemático - Configuración";StartPosition=FormStartPosition.CenterScreen;Size=new Size(600,430); Label t=new Label{Text="PROYECTO MATEMÁTICO",Font=new Font("Segoe UI",20,FontStyle.Bold),AutoSize=true,Location=new Point(145,35)};Controls.Add(t);Controls.Add(new Label{Text="Configuración del juego",AutoSize=true,Location=new Point(230,80)});
   Controls.Add(new Label{Text="Nombre del jugador 1:",AutoSize=true,Location=new Point(70,135)});p1=new TextBox{Location=new Point(240,130),Width=260};Controls.Add(p1);
   individual=new RadioButton{Text="Modo individual",AutoSize=true,Location=new Point(70,185),Checked=true};dos=new RadioButton{Text="Modo dos jugadores",AutoSize=true,Location=new Point(250,185)};Controls.Add(individual);Controls.Add(dos);
   Controls.Add(new Label{Text="Nombre del jugador 2:",AutoSize=true,Location=new Point(70,235)});p2=new TextBox{Location=new Point(240,230),Width=260,Enabled=false};Controls.Add(p2);dos.CheckedChanged+=(s,e)=>p2.Enabled=dos.Checked;
   Controls.Add(new Label{Text="La dificultad aumenta con el puntaje. Cada jugador tiene 3 vidas.",AutoSize=true,Location=new Point(70,280)});iniciar=new Button{Text="INICIAR JUEGO",Location=new Point(210,335),Size=new Size(180,40)};iniciar.Click+=Iniciar_Click;Controls.Add(iniciar);AcceptButton=iniciar; }
  void Iniciar_Click(object s,EventArgs e){string a=p1.Text.Trim(),b=p2.Text.Trim();if(a==""){MessageBox.Show("Ingrese el nombre del jugador 1.");return;}if(dos.Checked&&b==""){MessageBox.Show("Ingrese el nombre del jugador 2.");return;}Hide();using(var f=new JuegoForm(a,b,dos.Checked))f.ShowDialog();Close();}
 }
}
