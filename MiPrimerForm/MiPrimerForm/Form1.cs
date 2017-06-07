using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerForm
{
    public partial class Form1 : Form
    {
        // Facultades, Escuelas, Carreras

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object item = comboBoxFacultad.SelectedItem;
 
            //------------- Limpia items y texto actual--------------
            comboBoxEscuela.Text = "";
            comboBoxEscuela.Items.Clear();
            comboBoxEscuela.Enabled = true;
            comboBoxCarrera.Enabled = false;
            comboBoxCarrera.Text = "";
            comboBoxCarrera.Items.Clear();
            //-------------------------------------------------------
            String[] escuelas = leerEscuelas(item);

            foreach (String escuela in escuelas)
            {
                comboBoxEscuela.Items.Add(escuela);
            }

        }


        // Llena el ComboBox de Escuelas correspondientes a la facultad elegida.
        private String[] leerEscuelas(Object item)
        {
            String[] escuelas;
             if (item.Equals("Artes")) {
                escuelas = new String [] { "Artes Plásticas", "Cine, TV y Fotografía", "Crítica e Historia del Arte",
                    "Diseño Industrial y Modas", "Música", "Publicidad", "Teatro" };
                

            } else if (item.Equals("Ciencias")){
                escuelas = new String[] {"Biología", "Ciencias Geográficas", "Física", "Informática", "Matemáticas",
                    "Microbiología y Parasitología", "Química"};

            } else if (item.Equals("Ciencias Económicas y Sociales")){
                escuelas = new String[]{"Administración", "Contabilidad", "Economía", "Estadística","Mercadotecnia",
                    "Sociología"};

            } else if (item.Equals("Jurídicas y Políticas")){
                escuelas = new String[] { "Ciencias Políticas", "Derecho" };

            } else if (item.Equals("Ingeniería y Arquitectura")){
                escuelas = new String[] { "Agrimensura", "Arquitectura", "Electromecánica", "Ingeniería Civil",
                    "Ingeniería Industrial", "Ingeniería Química" };

            } else if (item.Equals("Ciencias de la Salud")){
                escuelas = new String[]{"Bioanálisis", "Enfermería", "Farmacia", "Medicina", "Odontología"};

            } else if (item.Equals("Ciencias Agronómicas y Veterinarias")){
                escuelas = new String[] { "Agronomía", "Veterinaria", "Zootecnia"};

            } else if (item.Equals("Ciencias de la Educación")){

                escuelas = new String []{"Bibliotecología", "Tecn e Innovación" ,
                    "Educación Física y Ciencias del Deporte", "Educación Infantil y Básica", "Educación Media",
                    "Orientación Educativa y Psicop", "Teoría y Gestión Educativa"};
            } else {
                escuelas = new String[]{"Comunicación Social", "Filosofía", "Historia y Antropología", "Idiomas",
                    "Letras", "Psicología"};

            }

            return escuelas;

        }



        private void comboBoxEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCarrera.Text = "";
            comboBoxCarrera.Items.Clear();
            comboBoxCarrera.Enabled = true;
            //llenarCarrerasEscuelas(comboBoxFacultad.SelectedIndex);
            Object facultad = comboBoxFacultad.SelectedItem;
            Object escuela = comboBoxEscuela.SelectedItem;
            String[] carreras; // En proceso

            //  Llena a la escuela correspodiente sus respectivas carreras.
            if (facultad.Equals("Artes")) {
                carreras = llenarCarrerasFacultadArtes(escuela);

            } else if (facultad.Equals("Jurídicas y Políticas")){
                carreras = llenarCarrerasFacultadJuridica(escuela);
            } else if (facultad.Equals("Ciencias")){
                carreras = llenarCarrerasFacultadCiencias(escuela);
            } else if (facultad.Equals("Humanidades")) {
                carreras = llenarCarrerasFacultadHumanidades(escuela);
            } else if (facultad.Equals("Ciencias de la Salud")) {
                carreras = llenarCarrerasFacultadSalud(escuela);
            } else if (facultad.Equals("Ciencias de la Educación")){
                carreras = llenarCarrerasFacultadEducacion(escuela);
            } else if (facultad.Equals("Ciencias Económicas y Sociales")){
                carreras = llenarCarrerasFacultadEconomicas(escuela);
            } else if (facultad.Equals("Ingeniería y Arquitectura")) {
                carreras = llenarCarrerasFacultadIngenieria(escuela);
            } else {
                carreras = llenarCarrerasFacultadAgrononomia(escuela);
            }
            

            foreach (String carrera in carreras)
            {
                comboBoxCarrera.Items.Add(carrera);
            }
        }

        // En proceso
        private String[] llenarCarrerasFacultadEconomicas(Object escuela)
        {
            String[] carreras;

            String[] administracion = { "Lic. en Administración de Empresas", "Lic. en Administración Publica", "Lic. en Adm de Empresas Turísticas y Hoteleras" };

            String[] contabilidad = { "Lic. en Contabilidad" };

            String[] economia = { "Lic. en Aduana y Comercio Exterior", "Lic. en Economía" };

            String[] estadistica = { "Lic. en Estadística Mención Informática", "Lic. en Estadística Mención Socioeconómica" };

            String[] mercadotecnia = { "Lic. en Mercadotecnia" };

            String[] sociologia = { "Lic. en Sociología", "Lic. en Trabajo Social" };

            /*, , , ,,
                    "Sociología"};*/

            if (escuela.Equals("Administración"))
            {
                carreras = administracion;
           
            } else if (escuela.Equals("Contabilidad"))
            {
                carreras = contabilidad;

            } else if (escuela.Equals("Economía"))
            {
                carreras = economia;
            } else if (escuela.Equals("Estadística"))
            {
                carreras = estadistica;
            } else if (escuela.Equals("Mercadotecnia"))
            {
                carreras = mercadotecnia;
            } else
            {
                carreras = sociologia;
            }


                return carreras;
        }   

        private String[] llenarCarrerasFacultadCiencias(Object escuela)
        {
            String[] carreras;
            String[] informatica = { "Lic. en Informática", "Tec Superior en Reparación y Ensamblaje de Computadoras" };
            String [] matematica = {"Lic. en Matemáticas"};
            String[] microbiologia = {"Lic. en Microbiología"};
            String[] quimica = {"Lic. en Química", "Tecnólogo Superior en Alimentos"};
            String[] biologia = {"Lic. en Biología"};
            String[] fisica = {"Lic. en Física"};
            String[] geografia = {"Lic. en Geografía", "Lic. en Geografía Mención Rec Naturales y Ecotur",
                "Lic. en Geografía Mención Represent Espacial" };

            if (escuela.Equals("Biología")) {
                carreras = biologia;
            } else if (escuela.Equals("Ciencias Geográficas")) {
                carreras = geografia;
            } else if (escuela.Equals("Física")) {
                carreras = fisica;

            } else if (escuela.Equals("Informática")) {
                carreras = informatica;
            } else if (escuela.Equals("Matemáticas")) {
                carreras = matematica;
            } else if (escuela.Equals("Microbiología y Parasitología")) {
                carreras = microbiologia;
            } else {
                carreras = quimica;
            }

            return carreras;
        }

        private String[] llenarCarrerasFacultadArtes(Object escuela) {
            // Carreras disponibles
            String[] carreras;

            String[] artesPlasticas = {"Lic. en Artes Plásticas", "Lic. en Artes Plásticas Mención Escultura",
                "Lic. en Artes Plásticas Mención Pintura" };

            String[] cineTV = {"Lic. en Cinematografía y Audiovisuales Mención Cine",
                "Lic. en Cinematografía y Audiovisuales Mención Televisión",
                "Técnico en Fotografía y Medios Audiovisuales"};

            String[] historiaArte = { "Lic. en Historia y Crítica del Arte" };

            String[] disenoIndustrial = {"Lic. en Artes Industriales Mención Diseño Artesanal" ,
                "Lic. en Artes Industriales Mención Diseño Industrial",
                "Lic. en Artes Industriales Mención Diseño de Modas" };

            String[] musica = { "Lic en Música", "Lic. en Música Mención Teoría y Educ." };

            String[] publicidad = {"Lic. en Publicidad Mención Diseño", "Lic. en Publicidad Mención Ilustración",
                "Lic. en Publicidad Menc Creatividad y Gerencia" };

            String[] teatro = {"Lic. en Teatro", "Lic. en Teatro Mención Actuación", "Lic. en Teatro Mención Dirección",
                "Lic. en Teatro Mención Dramaturgia" };


            if (escuela.Equals("Artes Plásticas")) {
                carreras = artesPlasticas;
            } else if (escuela.Equals("Cine, TV y Fotografía")){
                carreras = cineTV;
            } else if (escuela.Equals("Crítica e Historia del Arte")){
                carreras = historiaArte;
            } else if (escuela.Equals("Diseño Industrial y Modas")){
                carreras = disenoIndustrial;
            } else if (escuela.Equals("Música")){
                carreras = musica;
            } else if (escuela.Equals("Publicidad")) {
                carreras = publicidad;
            } else {
                carreras = teatro;
            }

            return carreras;
        }

        private String [] llenarCarrerasFacultadJuridica(Object escuela)
        {
            String[] carreras;
            if (escuela.Equals("Derecho"))
            {
                carreras = new String [] {"Lic. en Derecho"};
            } else {

                carreras = new String[] {"Lic. en Ciencias Políticas"};
            }
            return carreras;
        }

        private String [] llenarCarrerasFacultadEducacion(Object escuela)
        {

            return null;
        }
        private String[] llenarCarrerasFacultadHumanidades(Object escuela)
        {
            String[] carreras;
            String[] comunicacion = {"Lic. en Com Social Mención Comunicación Gráfica",
                "Lic. en Com Social Mención Periodismo", "Lic. en Com Social Mención Relaciones Públicas" };
            String[] filosofia = {"Lic. en Filosofía" };

            String[] historia = { "Lic. en Antropología", "Lic. en Historia" };

            String[] idiomas = { "Lic. en Lenguas Modernas Mención Francés", "Lic. en Lenguas Modernas Mención Inglés"};

            String[] letras = {"Lic. en letras" };

            String[] psicologia = { "Lic. en Psicología Mención Psi Del Desarr Humano",
                "Lic. en Psicología Mención Psicología Clínica", "Lic. en Psicología Mención Psicología Escolar",
            "Lic. en Psicología Mención Psicología Industrial", "Lic. en Psicología Mención Psicología Socal"};

            /*, , , ,
                    , "Psicología"*/

            if (escuela.Equals("Comunicación Social"))
            {
                carreras = comunicacion;

            }
            else if (escuela.Equals("Filosofía"))
            {
                carreras = filosofia;

            }
            else if (escuela.Equals("Historia y Antropología"))
            {
                carreras = historia;
            }
            else if (escuela.Equals("Idiomas"))
            {
                carreras = idiomas;
            }
            else if (escuela.Equals("Letras"))
            {
                carreras = letras;
            }
            else
            {
                carreras = psicologia;
            }

            return carreras;
        }

        private String [] llenarCarrerasFacultadIngenieria(Object escuela)
        {
            String[] carreras;

            String[] agrimensura = { "Agrimensura", "Ing. Geomática" };

            String[] arquitectura = { "Arquitectura" };

            String[] electromecanica = { "Ing. Electromecánica Mención Eléctrica", "Ing. Electromecánica Mención Mecánica", "Ing. Electromecánica Mención Electrónica" };

            String[] civil = { "Ing. Civil" };

            String[] industrial = { "Ing. Industrial" };

            String[] quimica = { "Ing. Química" };

            if (escuela.Equals("Agrimensura"))
            {
                carreras = agrimensura;

            }
            else if (escuela.Equals("Electromecánica"))
            {
                carreras = electromecanica;

            }
            else if (escuela.Equals("Ingeniería Civil"))
            {
                carreras = civil;
            }
            else if (escuela.Equals("Ingeniería Industrial"))
            {
                carreras = industrial;
            }
            else if (escuela.Equals("Ingeniería Química"))
            {
                carreras = quimica;
            }
            else
            {
                carreras = arquitectura;
            }

            return carreras;
        }

        private String[] llenarCarrerasFacultadSalud(Object escuela)
        {
            String[] carreras;

            String[] bioanalisis = { "Lic. en Bioanalisis", "Lic. en Imagenologia", "Técnico Radiólogo" };

            String[] enfermeria = { "Lic. en Enfermería" };

            String[] farmacia = { "Lic. en Farmacia" };

            String[] odontologia = { "Doctor en Odontología" };

            String[] medicina = { "Doctor en Medicina", "Pre-Médica/Medicina" };

            if (escuela.Equals("Bioanálisis")) {
                carreras = bioanalisis;
            } else if (escuela.Equals("Farmacia")) {
                carreras = farmacia;
            } else if (escuela.Equals("Medicina")) {
                carreras = medicina;
            } else if (escuela.Equals("Odontología")) {
                carreras = odontologia;
            } else {
                carreras = enfermeria;
            }

            return carreras;
        }

        private String[] llenarCarrerasFacultadAgrononomia(Object escuela)
        {
            String[] carreras;
            String[] agronomia = {"Ing. Agronómica-Mención Desarrollo Agrícola",
                "Ing. Agronómica-Mención Producción de Cultivos", "Ing. Agronómica-Mención Suelo y Riego"};

            String[] veterinaria = { "Medicina Veterinaria" };

            String[] zootecnia = {"Lic. en Industrias Lácteas", "Lic. en Producción Animal",
                "Técnico en Industrias Lácteas", "Técnico en Producción Animal"};

            if (escuela.Equals("Agronomía")) {
                carreras = agronomia;
            } else if (escuela.Equals("Veterinaria")){
                carreras = veterinaria;
            } else {
                carreras = zootecnia;
            }

            return carreras;
        }

        private void buttonSubirFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
