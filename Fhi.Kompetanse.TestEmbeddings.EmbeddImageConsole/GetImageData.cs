namespace Fhi.Kompetanse.TestEmbeddings.EmbeddImageConsole;

public class GetImageData
{
    public static List<Image> GetListImageData()
    {

        return new List<Image>()
        {
            new Image
            {
                Key = 0,
                Title = "Lion King",
                Description = "The Lion King is a classic Disney animated film that tells the story of a young lion named Simba who embarks on a journey to reclaim his throne as the king of the Pride Lands after the tragic death of his father."
            },
            new Image
            {
                Key = 1,
                Title = "Inception",
                Description = "Inception is a science fiction film directed by Christopher Nolan that follows a group of thieves who enter the dreams of their targets to steal information."
            },

            new Image
            {
                Key = 2,
                Title = "jaei0001.png",
                Description = @"
                            The image depicts a cat wearing a Santa hat and sweater, intently focused on a keyboard in front of it. The cat's attire is festive, with a red sweater featuring white buttons and a matching Santa hat adorned with a green holly sprig.
                            Key Features:
                            Cat: Gray, seated at a desk or table, facing the camera.
                            Attire: Red sweater with white buttons and a matching Santa hat with a green holly sprig.
                            Keyboard: Black, positioned in front of the cat.
                            Background: Out of focus, but appears to be a room decorated for Christmas.
                            Overall Impression:
                            The image presents a playful and humorous scene, capturing the attention of both humans and animals alike. The cat's adorable expression and festive attire make it an endearing subject, while the blurred background effectively draws the viewer's focus onto the cat itself.
                        "
            },
            new Image
            {
                Key = 3,
                Title = "jaei0002.png",
                Description = @"
                            This image presents a whimsical scene featuring a gray cat donning an orange bow tie and a black hooded cape, resembling a witch's cloak. The feline is intently focused on a laptop situated in front of it.
                            The laptop itself boasts a sleek black body with silver accents along its edges, adding a touch of sophistication to the otherwise playful atmosphere. The background of the image is tastefully decorated for Halloween, complete with cobwebs, pumpkins, and bats, creating a festive ambiance that perfectly complements the cat's witch-like attire.                        "
            },
            new Image
            {
                Key = 4,
                Title = "jaei0003.jpg",
                Description = @"
                        The image depicts a cluster of red and white mushrooms growing in the ground, surrounded by grass and other vegetation.

                        The mushrooms are bright red with white spots.
                        They have rounded caps that are slightly concave in the center.
                        The stems are thin and white.
                        Some of the mushrooms are clustered together, while others are spaced apart.
                        The background is filled with various types of greenery, including grasses and leaves.
                        There are also some small rocks or pebbles scattered throughout the area.
                        In the distance, there appears to be a body of water or a misty atmosphere.
                        Overall, the image suggests that the mushrooms are growing in a natural environment, possibly in a forest or woodland
                "
            }



        };

    }
}