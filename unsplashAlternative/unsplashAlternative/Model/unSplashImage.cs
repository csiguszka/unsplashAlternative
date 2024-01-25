using System.Collections.Generic;
using System;

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

public class Sponsorship
{
    public IList<string> impression_urls { get; set; }
    public string tagline { get; set; }
    public string tagline_url { get; set; }
    public Sponsor sponsor { get; set; }
}

public class TexturesPatterns
{
    public string status { get; set; }
}

public class dRenders
{
    public string status { get; set; }
}

public class StreetPhotography
{
    public string status { get; set; }
    public DateTime approved_on { get; set; }
}

public class ArchitectureInterior
{
    public string status { get; set; }
}

public class Wallpapers
{
    public string status { get; set; }
}

public class Minimalism
{
    public string status { get; set; }
}

public class TopicSubmissions
{
    public TexturesPatterns textures_patterns { get; set; }
    public dRenders d_renders { get; set; }
    public StreetPhotography street_photography { get; set; }
    public ArchitectureInterior architecture_interior { get; set; }
    public Wallpapers wallpapers { get; set; }
    public Minimalism minimalism { get; set; }
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

public class unSplashImage
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
    public IList<object> breadcrumbs { get; set; }
    public Urls urls { get; set; }
    public Links links { get; set; }
    public int likes { get; set; }
    public bool liked_by_user { get; set; }
    public IList<object> current_user_collections { get; set; }
    public Sponsorship sponsorship { get; set; }
    public TopicSubmissions topic_submissions { get; set; }
    public User user { get; set; }
}
