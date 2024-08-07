namespace Mi_Web_Mvc.Models
{
    public static class Info
    {
        public static string TituloIndex { get; } = "TurismoYa, tu empresa de turismo por excelencia";
        public static string SubtituloIndex { get; } = "Andorra";
        public static string TituloActividades { get; } = "Actividades";
        public static string TituloCiudades { get; } = "Ciudades";

        public static List<Carta> cartasIndex { get; } = new List<Carta>
        {
            new Carta
            {
                Titulo = "Ubicacion",
                Imagen = "Images/puebloAndorra.jpg",
                Contenido = "Andorra se encuentra en el sudoeste de Europa, en el corazón de los Pirineos Orientales. El país hace frontera con España por la comunidad autónoma de Cataluña y con Francia, por el departamento de l’Ariège."
            },
            new Carta
            {
                Titulo = "Superficie",
                Imagen = "Images/superficieAndorra.jpg",
                Contenido = "Con 468 km2 de superficie, solo un 8 % es terreno urbanizado; el 92 % restante es territorio forestal, lo cual convierte al país en un paraíso para los amantes de la naturaleza. Además de su impresionante paisaje montañoso, Andorra es conocida por sus numerosos lagos de origen glaciar, que ofrecen oportunidades para practicar senderismo, pesca y simplemente disfrutar de la serenidad de la naturaleza."
            },
            new Carta
            {
                Titulo = "Idioma",
                Imagen = "Images/idiomaAndorra.jpg",
                Contenido = "El catalán es nuestra lengua oficial, aunque la diversidad de nacionalidades que conforman la población residente hace que estén muy presentes otros idiomas como el castellano, el francés y el portugués. Además de estos idiomas, el inglés también es ampliamente entendido y hablado, especialmente en áreas turísticas y comerciales."
            },
            new Carta
            {
                Titulo = "Clima",
                Imagen = "Images/climaAndorra.jpg",
                Contenido = "Andorra goza de un clima de alta montaña con influencias del mediterráneo, con un verano caluroso y un invierno frío con nevadas importantes. La temperatura media mínima es de -2 ºC y la máxima, de 24 ºC. Las precipitaciones en forma de nieve son frecuentes y las lluvias se concentran principalmente entre los meses de mayo y octubre. Este clima diverso ofrece oportunidades para una amplia gama de actividades durante todo el año, desde esquiar en las montañas hasta practicar senderismo y ciclismo en verano"
            },
            new Carta
            {
                Titulo = "Horario",
                Imagen = "Images/horarioAndorra.jpg",
                Contenido = "Como en España y Francia, Andorra aplica el horario marcado por el meridiano de Greenwich (GMT + 1). Esto significa que la mayoría de las tiendas, restaurantes y atracciones turísticas están abiertas de 9 a.m. a 9 p.m., aunque los horarios pueden variar según la temporada y el día de la semana. Además, durante los meses de verano, muchos establecimientos extienden sus horarios para adaptarse al mayor número de visitantes."
            }
        };
        public static List<Carta> cartasActividades { get; } = new List<Carta>
        {
            new Carta
            {
                Titulo = "Visitar la capital del pais: \"Andorra La Vieja\"",
                Imagen = "../Images/capitalAndorra.jpg",
                Contenido = "Andorra la Vieja es la capital de este pequeño y hermoso país. Hay muchas cosas para hacer como visitar monumentos, ir de compras o cenar en diversos restaurantes conocidos por los locales..."
            },
            new Carta
            {
                Titulo = "Esquiar",
                Imagen = "../Images/AndorraEsqui.jpeg",
                Contenido = "Andorra es conocida por estar encerrada en montañas nevadas que son un buen lugar para esquiar. Si visitas Andorra, no puedes dejar de esquiar en diversos lugares del país."
            },
            new Carta
            {
                Titulo = "Micro turístico",
                Imagen = "../Images/microAndorra.jpeg",
                Contenido = "Visitar Andorra en un micro turístico es más cómodo. Este recorrido hace paradas en diversos puntos de interés, siendo una actividad recomendada por muchos."
            },
            new Carta
            {
                Titulo = "La Noblesse du Temps",
                Imagen = "../Images/esculturaAndorra.jpg",
                Contenido = "Situada en el Pont de la Rotonda se halla la escultura “Noblesse du Temps” de Salvador Dalí. Es una pieza realizada en bronce, con un peso total de 1400 kg y dimensiones de 4,90 m de altura..."
            }
        };
        public static List<Carta> cartasCiudades { get; } = new List<Carta>
        {
            new Carta
            {
                Titulo = "Andorra la vieja",
                Imagen = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d11765.450650728506!2d1.5100658232342505!3d42.50510045790649!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a5f52b4a25fb0b%3A0xa00947091997280!2sAD500%20Andorra%20la%20Vella%2C%20Andorra!5e0!3m2!1ses!2sar!4v1713992091730!5m2!1ses!2sar",
                Contenido = "Dotada de 22 250 habitantes, Andorra la Vieja es la capital del Principado y la ciudad principal de Andorra. Está situada al sudoeste del país, en la valle del Valira. ¡Su altitud de 1 013 metros hace de ella la capital más alta de Europa! Centro neurálgico del país, Andorra la Vieja reúne la mayoría de los servicios (educación, salud) y instituciones del Principado de Andorra, incluso el Gobierno del país. La ciudad andorrana de referencia es conocida también por sus formidables condiciones de acogida, sus numerosos hoteles y restaurantes así como sus condiciones de compras incomparables. Capital política y económica del país, albergaba hasta 1978 la ciudad andorrana de Escaldes-Engordany, convertida hoy en parroquia de pleno derecho. ¡De hecho, Andorra la Vieja es ahora la parroquia más pequeña del territorio andorrano, pero no la menos poblada!"
            },
            new Carta
            {
                Titulo = "La Massana",
                Imagen = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d11758.136502341242!2d1.496965273766926!3d42.54395011275051!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12af5ffa2711aa37%3A0xa00947091997180!2sAD400%20La%20Massana%2C%20Andorra!5e0!3m2!1ses!2sar!4v1713992268755!5m2!1ses!2sar",
                Contenido = "Culminando a 1 230 metros de altitud al sur del país, La Massana es una de las principales ciudades del Principado de Andorra. La parroquia del mismo nombre revela hermosos pueblos andorranos acogiendo los “Massanencs”, los 10 000 habitantes que componen este distrito. Mencionemos los pueblos de Pal y de Arinsal, conocidos de los esquiadores y aficionados de deportes de invierno habituales de la estación de Vallnord, y también los pueblos de Erts, Sispony, Anyos, L’Aldosa, Escas, Xixerella, El Pui, Puiol del Piu o Mas de Ribafeta. El Pic de Coma Pedrosa (2 942 m), punto culminante del Principado de Andorra, está situado en esta parroquia."
            },
            new Carta
            {
                Titulo = "Encamp",
                Imagen = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d5879.970501336867!2d1.5755180976562508!3d42.534368040504134!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a58a0b8d4d3c0d%3A0xa009470919970f0!2sAD200%20Encamp%2C%20Andorra!5e0!3m2!1ses!2sar!4v1713992323577!5m2!1ses!2sar",
                Contenido = "Los 14 000 “Encampadans” son los habitantes de la parroquia de Encamp, cuya ciudad del mismo nombre es importante en Andorra. Este territorio de montaña de una altitud media de 1 250 metros acoge también en su seno magníficos pueblos andorranos: Le Tremat, La Mosquera, Les Bons, Vila y Grau Roig. Reputado por sus precios favorecedores en muchas mercancías y las posibilidades de inversiones muy interesantes que ofrece, el pueblo andorrano-fronterizo del Pas de la Casa forma parte también de la parroquia de Encamp. Es un paso obligatorio para las personas que llegan de Francia via el célebre Puerto de Envalira. ¡La parroquia de Encamp ofrece también un gran parte de la zona de esquí de Grandvalira, la más vasta de los Pirineos!"
            },
            new Carta
            {
                Titulo = "Escaldes-Engordany",
                Imagen = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d5882.092045467448!2d1.5357609476527874!3d42.51182994336465!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a58ae2f44a1a6b%3A0xfddec554f21e9eb6!2sAD700%20Las%20Escaldas%2C%20Andorra!5e0!3m2!1ses!2sar!4v1713992356269!5m2!1ses!2sar",
                Contenido = "Extendiéndose sobre 47km2, la parroquia de Escaldes-Engordany contiene una otra ciudad importante del Principado de Andorra, Escaldes-Engordany, compuesta originalmente de los pueblos de Escaldes y Engordany. La parroquia se eleva a 1 050 metros de altitud y junta aproximadamente 17 000 habitantes llamados “Escaldencs”. Los pueblos andorranos de Vilars d’Engordany, Engolasters, y El Fener, están construidos en este territorio, conocido también por ser la sede de la hermosa valle salvaje del Madriu, con su fauna y flora conservada y las iglesias romanas de Sant Roma dels Vilars y de Sant Miquel de Engolasters. El centro termo-lúdico Caldea, complejo termal único en Europa asociando dispositivos de salud y de diversión, constituye también una atracción mayor de Escaldes-Engordany"
            }
        };

    }

    public class Carta
    {
        public string Titulo { get; set; }
        public string Imagen { get; set; }
        public string Contenido { get; set; }
    }
}
