# Architecture of the Blog Component

## General Components

Blog Post
- ID 
- Date
- Title
- Content
- Image (Path)
- Category (soon to be replaced with tags)
- Author

## Considerations

I'd like to be able to support blog posts with pictures intermittently included throughout the blog post. I wonder if a BlogPostPart concept would work, where each blog is a collection of BlogPostParts, each containing a block of text and a photo. That way I'd be able to iteratively render each blog part for each post to position the images properly. 

## Resources
This resource is great for applying migrations when changing the model
https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/complex-data-model?view=aspnetcore-2.0
