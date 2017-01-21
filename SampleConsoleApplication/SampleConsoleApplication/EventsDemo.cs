using System;
using System.Security.AccessControl;
using System.Security.Policy;
using Microsoft.SqlServer.Server;

namespace SampleConsoleApplication {

    
    public delegate void  VideoEncoderHandler(object source,EventArgs args);

    public class EventsDemo
    {
        public static void Main(string[] args)
        {
            Video video=new Video();
            VideoEncoder videoEncoder=new VideoEncoder();
            MailSender mailSender =new MailSender();
            videoEncoder.VideEncoderEvent += mailSender.OnVideoEncodedEvent;
            videoEncoder.Encode(video);
            Console.ReadLine();

        }

    }


    public class Video
    {
        public string VideoName { get; set; }

    }

    public class VideoEncoder
    {
        public event VideoEncoderHandler VideEncoderEvent ;
        public void Encode(Video video)
        {
            Console.WriteLine("Enconding  is completed ");
            OnVideEncodedEvent();

        }

        public void OnVideEncodedEvent()
        {
            if (VideEncoderEvent!=null)
            {
                VideEncoderEvent(this,EventArgs.Empty);
            }
        }


    }

    public class MailSender
    {
        public void OnVideoEncodedEvent(Object source,EventArgs args)
        {
            Console.WriteLine("Mail Sent Successfully");
        }
    }




}