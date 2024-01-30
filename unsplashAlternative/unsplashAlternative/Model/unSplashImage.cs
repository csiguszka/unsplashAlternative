using System.Collections.Generic;
using System;

public class Breadcrumb
{
    public string slug { get; set; }
    public string title { get; set; }
    public int index { get; set; }
    public string type { get; set; }
}

public class Urls
{
    public string raw { get; set; }
    public string full { get; set; }
    public string regular { get; set; }
    public string small { get; set; }
    public string thumb { get; set; }
    public string small_s3 { get; set; }
}

public class Links
{
    public string self { get; set; }
    public string html { get; set; }
    public string download { get; set; }
    public string download_location { get; set; }
}

public class ProfileImage
{
    public string small { get; set; }
    public string medium { get; set; }
    public string large { get; set; }
}

public class Social
{
    public string instagram_username { get; set; }
    public string portfolio_url { get; set; }
    public string twitter_username { get; set; }
    public object paypal_email { get; set; }
}

public class Sponsor
{
    public string id { get; set; }
    public DateTime updated_at { get; set; }
    public string username { get; set; }
    public string name { get; set; }
    public string first_name { get; set; }
    public object last_name { get; set; }
    public string twitter_username { get; set; }
    public string portfolio_url { get; set; }
    public string bio { get; set; }
    public object location { get; set; }
    public Links links { get; set; }
    public ProfileImage profile_image { get; set; }
    public string instagram_username { get; set; }
    public int total_collections { get; set; }
    public int total_likes { get; set; }
    public int total_photos { get; set; }
    public int total_promoted_photos { get; set; }
    public bool accepted_tos { get; set; }
    public bool for_hire { get; set; }
    public Social social { get; set; }
}

public class Sponsorship
{
    public IList<object> impression_urls { get; set; }
    public string tagline { get; set; }
    public string tagline_url { get; set; }
    public Sponsor sponsor { get; set; }
}

public class BusinessWork
{
    public string status { get; set; }
    public DateTime approved_on { get; set; }
}

public class DigitalNomad
{
    public string status { get; set; }
    public DateTime approved_on { get; set; }
}

public class Entrepreneur
{
    public string status { get; set; }
    public DateTime approved_on { get; set; }
}

public class Technology
{
    public string status { get; set; }
    public DateTime approved_on { get; set; }
}

public class Interiors
{
    public string status { get; set; }
}

public class DigitalScreens
{
    public string status { get; set; }
    public DateTime approved_on { get; set; }
}

public class WorkFromHome
{
    public string status { get; set; }
    public DateTime approved_on { get; set; }
}

public class TopicSubmissions
{
    public BusinessWork business_work { get; set; }
public DigitalNomad digital_nomad { get; set; }
public Entrepreneur entrepreneur { get; set; }
public Technology technology { get; set; }
public Interiors interiors { get; set; }
public DigitalScreens digital_screens { get; set; }
public WorkFromHome work_from_home { get; set; }
    }

    public class User
{
    public string id { get; set; }
    public DateTime updated_at { get; set; }
    public string username { get; set; }
    public string name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string twitter_username { get; set; }
    public string portfolio_url { get; set; }
    public string bio { get; set; }
    public string location { get; set; }
    public Links links { get; set; }
    public ProfileImage profile_image { get; set; }
    public string instagram_username { get; set; }
    public int total_collections { get; set; }
    public int total_likes { get; set; }
    public int total_photos { get; set; }
    public int total_promoted_photos { get; set; }
    public bool accepted_tos { get; set; }
    public bool for_hire { get; set; }
    public Social social { get; set; }
}

public class Type
{
    public string slug { get; set; }
    public string pretty_slug { get; set; }
}

public class Category
{
    public string slug { get; set; }
    public string pretty_slug { get; set; }
}

public class Subcategory
{
    public string slug { get; set; }
    public string pretty_slug { get; set; }
}

public class Ancestry
{
    public Type type { get; set; }
    public Category category { get; set; }
    public Subcategory subcategory { get; set; }
}

public class Breadcrumb2
{
    public string slug { get; set; }
    public string title { get; set; }
    public int index { get; set; }
    public string type { get; set; }
}

public class CoverPhoto
{
    public string id { get; set; }
    public string slug { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public DateTime promoted_at { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string color { get; set; }
    public string blur_hash { get; set; }
    public string description { get; set; }
    public string alt_description { get; set; }
    public IList<Breadcrumb> breadcrumbs { get; set; }
    public Urls urls { get; set; }
    public Links links { get; set; }
    public int likes { get; set; }
    public bool liked_by_user { get; set; }
    public IList<object> current_user_collections { get; set; }
    public object sponsorship { get; set; }
    public TopicSubmissions topic_submissions { get; set; }
    public bool premium { get; set; }
    public bool plus { get; set; }
    public User user { get; set; }
}

public class Source
{
    public Ancestry ancestry { get; set; }
    public string title { get; set; }
    public string subtitle { get; set; }
    public string description { get; set; }
    public string meta_title { get; set; }
    public string meta_description { get; set; }
    public CoverPhoto cover_photo { get; set; }
}

public class Tag
{
    public string type { get; set; }
    public string title { get; set; }
    public Source source { get; set; }
}

public class Result
{
    public string id { get; set; }
    public string slug { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public DateTime? promoted_at { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string color { get; set; }
    public string blur_hash { get; set; }
    public string description { get; set; }
    public string alt_description { get; set; }
    public IList<Breadcrumb> breadcrumbs { get; set; }
    public Urls urls { get; set; }
    public Links links { get; set; }
    public int likes { get; set; }
    public bool liked_by_user { get; set; }
    public IList<object> current_user_collections { get; set; }
    public Sponsorship sponsorship { get; set; }
    public TopicSubmissions topic_submissions { get; set; }
    public User user { get; set; }
    public IList<Tag> tags { get; set; }
}

public class unSplashImage
{
    public int total { get; set; }
    public int total_pages { get; set; }
    public IList<Result> results { get; set; }
}

