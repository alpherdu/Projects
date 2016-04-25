using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Classes
{
public abstract class AlbumDecorator : Album
{
    protected Album _album;

    public AlbumDecorator(Album album)
    {
        _album = album;
    }

    public override void Draw()
    {
        _album.Draw();
    } 
}
}
