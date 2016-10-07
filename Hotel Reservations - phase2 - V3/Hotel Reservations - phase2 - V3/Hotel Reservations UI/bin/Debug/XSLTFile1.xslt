<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
 
  
  
  <xsl:template match="/">
    <html>
      <head>
        <title>Hotels</title>
      </head>
      <body>
        <h2>

              <font size="5">Hotels in Florida</font>
       
        </h2>

        <table style="background-color:white" border="1" cellpadding="4" cellspacing="1" width="80%" >
          <tr>
            <th>Name</th>
            <th>Rating</th>
            <th>Average Price Per Night</th>
          </tr>


          <xsl:apply-templates select="ArrayOfHotelListItem/HotelListItem">
            <xsl:sort select="Rating" order="descending" data-type="number" />
          </xsl:apply-templates>
          <br/>
        </table>
            
          
         
          

      </body>
    </html>
  </xsl:template>


  

  <xsl:template match="HotelListItem">
    <tr>
    <td>
    <xsl:value-of select="Name"/>
    </td>
    <td>
      
      <xsl:if test="Rating = 4.5">
        <img src="http://i.imgur.com/CrtQxzX.png"></img>
      </xsl:if>
      
      <xsl:if test="Rating = 4">
        <img src="http://i.imgur.com/V3jWKQz.png"></img>
      </xsl:if>

      <xsl:if test="Rating = 3.5">      
          <img src="http://i.imgur.com/SZ1fgQJ.png"></img>
      </xsl:if>

      <xsl:if test="Rating = 3">
        <img src="http://i.imgur.com/zVQFDq9.png"></img>
      </xsl:if>

      <xsl:if test="Rating = 2.5">
        <img src="http://i.imgur.com/YFW91NU.png"></img>
      </xsl:if>

      <xsl:if test="Rating = 1.5">
        <img src="http://i.imgur.com/lxGJHNw.png"></img>
      </xsl:if>
      
    </td>
    <td>
      <xsl:for-each select="roomTypes/Room">

        <xsl:value-of select="ID"/> = 
        <xsl:value-of select="DailyRate"/> &#160;

      </xsl:for-each>
    </td>
    </tr>
    
 </xsl:template>

  <xsl:template match="Room">
    <!--
    <xsl:if test="ID = 'Single King Bed'">
      Single King Bed = $<xsl:value-of select="DailyRate"/>
    </xsl:if>

    <xsl:if test="ID = 'Single Queen Bed'">
      Single Queen Bed = $<xsl:value-of select="DailyRate"/>
    </xsl:if>

    <xsl:if test="ID = 'Two Double Beds'">
      Two Double Beds = $<xsl:value-of select="DailyRate"/>
    </xsl:if>

    <xsl:if test="ID = 'One Bedroom Suite'">
      One Bedroom Suite = $<xsl:value-of select="DailyRate"/>
    </xsl:if>
-->
    
  
  
  </xsl:template>



  
  
 
</xsl:stylesheet>



