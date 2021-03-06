// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace AlfaBot.Host.Model
{
    /// <inheritdoc />
    public class AddMessageStatusOutDto : StatusOutDto
    {
        /// <summary>
        /// Id of the sended message
        /// </summary>
        public int MessageId { get; set; }
    }
}