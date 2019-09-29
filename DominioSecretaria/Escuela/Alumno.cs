using DominioSecretaria.Faltas;
using DominioSecretaria.InfoPersonal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DominioSecretaria.Escuela
{
    public class Alumno: EsPersona
    {        
        public int legajo { get; set; }

        [ForeignKey("idCursoActual")]
        public Curso CursoActual { get; set; }

        [Column("libro")]
        public int Libro { get; set; }

        [Column("folio")]
        public int Folio { get; set; }        

        public List<Seguimiento> Seguimientos { get; set; }
        public List<Tutor> Tutores { get; set; }
        public List<Cursada> Cursadas { get; set; }

        public Alumno(Persona persona) : base(persona)
        {
            iniciarListas();
        }

        public Alumno():base()
        {
            iniciarListas();
        }

        public void agregarmeAlCurso(Curso curso)
        {
            sacarCursoActual();
            this.CursoActual = curso;
            curso.agregarAlumno(this);
        }

        public void cambiarCurso(Curso curso, DateTime fecha, short cicloLectivo)
        {
            agregarmeAlCurso(curso);
            agregarACursada(curso, fecha, cicloLectivo);
        }

        private void agregarACursada(Curso curso, DateTime fecha, short cicloLectivo)
        {
            var cursada = new Cursada()
            {
                Alumno = this,
                Fecha = fecha,
                CicloLectivo = cicloLectivo,
                Curso = curso
            };
            Cursadas.Add(cursada);
        }

        private void sacarCursoActual()
        {
            if (this.CursoActual != null)
            {
                CursoActual.sacarAlumno(this);
            }
        }

        public void agregarTutor(Tutor tutor)
        {
            Tutores.Add(tutor);
        }

        private void iniciarListas()
        {
            Tutores = new List<Tutor>();
            Seguimientos = new List<Seguimiento>();
            Cursadas = new List<Cursada>();
        }

        public List<Falta> faltasActualCiclo()
        {
            var cicloActual = (short)DateTime.Now.Date.Year;
            return faltasParaCiclo(cicloActual);
        }

        public List<Falta> faltasParaCiclo(short cicloLectivo)
            =>  Cursadas.FindAll(cursada => cursada.CicloLectivo == cicloLectivo)
                        .SelectMany(cursada => cursada.Faltas)
                        .ToList();

        private void agregarAlDiccionario(Cursada cursada, Dictionary<short, List<Falta>> diccionarioFaltas)
        {
            if (diccionarioFaltas.ContainsKey(cursada.CicloLectivo))
            {
                diccionarioFaltas[cursada.CicloLectivo].AddRange(cursada.Faltas);
            }
            else
            {
                diccionarioFaltas.Add(cursada.CicloLectivo, cursada.Faltas);
            }
        }

        public void agregarSeguimiento(Seguimiento seguimiento)
        {
            this.Seguimientos.Add(seguimiento);
            seguimiento.Alumno = this;
        }
    }
}