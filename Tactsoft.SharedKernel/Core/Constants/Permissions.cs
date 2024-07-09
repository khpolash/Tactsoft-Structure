namespace Tactsoft.SharedKernel.Core.Constants;

public class Permissions
{
    public static List<string> GeneratePermissionsForModule(string module)
    {
        return new List<string>()
        {
            $"Permissions.{module}.Create",
            $"Permissions.{module}.View",
            $"Permissions.{module}.Edit",
            $"Permissions.{module}.Delete",
        };
    }

    public static class Users
    {
        public const string View = "Permissions.Users.View";
        public const string Create = "Permissions.Users.Create";
        public const string Edit = "Permissions.Users.Edit";
        public const string ManageRoles = "Permissions.Users.ManageRoles";
        public const string ManageClaims = "Permissions.Users.ManageClaims";
        public const string Delete = "Permissions.Users.Delete";
    }


    public static class Roles
    {
        public const string View = "Permissions.Roles.View";
        public const string Create = "Permissions.Roles.Create";
        public const string Edit = "Permissions.Roles.Edit";
        public const string Delete = "Permissions.Roles.Delete";
        public const string ManageClaims = "Permissions.Roles.ManageClaims";
    }

    public static class Airport
    {
        public const string View = "Permissions.Airport.View";
        public const string Create = "Permissions.Airport.Create";
        public const string Edit = "Permissions.Airport.Edit";
        public const string Delete = "Permissions.Airport.Delete";
    }

    public static class Airline
    {
        public const string View = "Permissions.Airline.View";
        public const string Create = "Permissions.Airline.Create";
        public const string Edit = "Permissions.Airline.Edit";
        public const string Delete = "Permissions.Airline.Delete";
    }

    public static class ConfirmBooking
    {
        public const string View = "Permissions.ConfirmBooking.View";
        public const string Create = "Permissions.ConfirmBooking.Create";
        public const string Edit = "Permissions.ConfirmBooking.Edit";
        public const string Delete = "Permissions.ConfirmBooking.Delete";
    }
    public static class ConfirmVisaBooking
    {
        public const string View = "Permissions.ConfirmVisaBooking.View";
        public const string Create = "Permissions.ConfirmVisaBooking.Create";
        public const string Edit = "Permissions.ConfirmVisaBooking.Edit";
        public const string Delete = "Permissions.ConfirmVisaBooking.Delete";
    }
    public static class Country
    {
        public const string View = "Permissions.Country.View";
        public const string Create = "Permissions.Country.Create";
        public const string Edit = "Permissions.Country.Edit";
        public const string Delete = "Permissions.Country.Delete";
    }
    public static class ExclusiveOffer
    {
        public const string View = "Permissions.ExclusiveOffer.View";
        public const string Create = "Permissions.ExclusiveOffer.Create";
        public const string Edit = "Permissions.ExclusiveOffer.Edit";
        public const string Delete = "Permissions.ExclusiveOffer.Delete";
    }

    public static class Faq
    {
        public const string View = "Permissions.Faq.View";
        public const string Create = "Permissions.Faq.Create";
        public const string Edit = "Permissions.Faq.Edit";
        public const string Delete = "Permissions.Faq.Delete";
    }
    public static class Flight
    {
        public const string View = "Permissions.Flight.View";
        public const string Create = "Permissions.Flight.Create";
        public const string Edit = "Permissions.Flight.Edit";
        public const string Delete = "Permissions.Flight.Delete";
    }
    public static class FlightReservation
    {
        public const string View = "Permissions.FlightReservation.View";
        public const string Create = "Permissions.FlightReservation.Create";
        public const string Edit = "Permissions.FlightReservation.Edit";
        public const string Delete = "Permissions.FlightReservation.Delete";
    }
    public static class Hotel
    {
        public const string View = "Permissions.Hotel.View";
        public const string Create = "Permissions.Hotel.Create";
        public const string Edit = "Permissions.Hotel.Edit";
        public const string Delete = "Permissions.Hotel.Delete";
    }

    public static class HotelReservation
    {
        public const string View = "Permissions.HotelReservation.View";
        public const string Create = "Permissions.HotelReservation.Create";
        public const string Edit = "Permissions.HotelReservation.Edit";
        public const string Delete = "Permissions.HotelReservation.Delete";
    }
    public static class ImageGallery
    {
        public const string View = "Permissions.ImageGallery.View";
        public const string Create = "Permissions.ImageGallery.Create";
        public const string Edit = "Permissions.ImageGallery.Edit";
        public const string Delete = "Permissions.ImageGallery.Delete";
    }
    public static class ImageSlider
    {
        public const string View = "Permissions.ImageSlider.View";
        public const string Create = "Permissions.ImageSlider.Create";
        public const string Edit = "Permissions.ImageSlider.Edit";
        public const string Delete = "Permissions.ImageSlider.Delete";
    }
    public static class Policy
    {
        public const string View = "Permissions.Policy.View";
        public const string Create = "Permissions.Policy.Create";
        public const string Edit = "Permissions.Policy.Edit";
        public const string Delete = "Permissions.Policy.Delete";
    }
    public static class Room
    {
        public const string View = "Permissions.Room.View";
        public const string Create = "Permissions.Room.Create";
        public const string Edit = "Permissions.Room.Edit";
        public const string Delete = "Permissions.Room.Delete";
    }
    public static class TourPackage
    {
        public const string View = "Permissions.TourPackage.View";
        public const string Create = "Permissions.TourPackage.Create";
        public const string Edit = "Permissions.TourPackage.Edit";
        public const string Delete = "Permissions.TourPackage.Delete";
    }
    public static class VisaRequest
    {
        public const string View = "Permissions.VisaRequest.View";
        public const string Create = "Permissions.VisaRequest.Create";
        public const string Edit = "Permissions.VisaRequest.Edit";
        public const string Delete = "Permissions.VisaRequest.Delete";
    }
    public static class VisaRequirement
    {
        public const string View = "Permissions.VisaRequirement.View";
        public const string Create = "Permissions.VisaRequirement.Create";
        public const string Edit = "Permissions.VisaRequirement.Edit";
        public const string Delete = "Permissions.VisaRequirement.Delete";
    }
}