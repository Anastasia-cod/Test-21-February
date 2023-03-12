using System;
namespace VS_21_February.Task7.autopark
{
	public class TransportService
	{
        public TransportService()
        {
        }

        public string PrintTransportType(PublicTransport publicTransport)
        {
            return publicTransport.ReturnType();
        }
    }
}

