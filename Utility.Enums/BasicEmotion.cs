namespace Utility.Enums
{
    /// <summary>
    ///  Robert Plutchik's theory defines that the eight basic emotions are:[1]
    ///  Plutchik's Wheel of Emotions
    /// </summary>
    public enum BasicEmotion : byte
    {
        None,
        Fear = 1,// → feeling of being afraid, frightened, scared.
        Anger,// → feeling angry.A stronger word for anger is rage
        Sadness,// → feeling sad. Other words are sorrow, grief (a stronger feeling, for example when someone has died)
        Joy,// → feeling happy.Other words are happiness, gladness
        Disgust,// → feeling something is wrong or nasty.Strong disapproval.
        Surprise,// → being unprepared for something.
        Trus,//t → a positive emotion; admiration is stronger; acceptance is weaker.
        Anticipation,//→ in the sense of looking forward positively to something which is going to happen.Expectation is more neutral
    }
}