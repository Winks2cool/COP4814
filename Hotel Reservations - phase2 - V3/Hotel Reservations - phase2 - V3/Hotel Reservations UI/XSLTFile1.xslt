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

        <table style="background-color:white" border="1" cellpadding="4" cellspacing="1" width="100%" >
          <tr>
            <th>Name</th>
            <th>Rating</th>
            <th colspan="4" align="center"> Average Price Per Night</th>
            
            
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

      <xsl:if test="Rating = 5.0">
        <img src="http://i.imgur.com/8ouYojK.png"></img>
      </xsl:if>
      
      <xsl:if test="Rating = 4.5">
        <img src="http://i.imgur.com/2dm7235.png"></img>
      </xsl:if>
      
      <xsl:if test="Rating = 4">
        <img src="http://i.imgur.com/Q9X2uem.png"></img>
      </xsl:if>

      <xsl:if test="Rating = 3.5">      
          <img src="http://i.imgur.com/QhoH1uj.png"></img>
      </xsl:if>

      <xsl:if test="Rating = 3">
        <img src="http://i.imgur.com/UhgQBh9.png"></img>
      </xsl:if>

      <xsl:if test="Rating = 2.5">
        <img src="http://i.imgur.com/3lleUwI.png"></img>
      </xsl:if>

       <xsl:if test="Rating = 2.0">
        <img src="http://i.imgur.com/gqnf6OI.png"></img>
      </xsl:if>

      <xsl:if test="Rating = 1.5">
        <img src="http://i.imgur.com/BPKtjGQ.png"></img>
      </xsl:if>
      
    </td>

 
      <xsl:for-each select="roomTypes/Room">

        
         <td>
        
          <xsl:value-of select="ID"/> = $
          <xsl:value-of select="DailyRate"/> &#160;
         </td>
        
      </xsl:for-each>
    
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



