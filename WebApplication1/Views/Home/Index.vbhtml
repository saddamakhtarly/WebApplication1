
@ModelType WebApplication1.FModel

@Code
    ViewData("Title") = "Home Page"
End Code



<div class="row">
    <!--
      <div class="col-md-6">
          <h1>
              @For Each item1 As String In Model.List1
                  @item1

              Next

              @For Each item2 As String In Model.List2
                  @item2

              Next
          </h1>
      </div>
        -->
    <link href="//netdna.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <!------ Include the above in your HEAD tag ---------->

    <link href="//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet">

    <div class="nav-side-menu">
        
        <i class="fa fa-bars fa-2x toggle-btn" data-toggle="collapse" data-target="#menu-content"></i>

        <div class="menu-list">

            <ul id="menu-content" class="menu-content collapse out">
               

                <li data-toggle="collapse" data-target="#products" class="collapsed active">
                    <a href="#"> List 1 <span class="arrow"></span></a>
                </li>
                <ul class="sub-menu collapse" id="products">
                    @For Each item1 As String In Model.List1
                        @<li><a href = "#" >  @item1</a></li>


                    Next
                    
                    
                    
                </ul>


                <li data-toggle="collapse" data-target="#service" Class="collapsed">
                    <a href="#"> List 2 <span Class="arrow"></span></a>
                </li>
                <ul Class="sub-menu collapse" id="service">
                    @For Each item2 As String In Model.List2
                        @<li><a href="#">  @item2</a></li> 

                    Next

                </ul>


                


            </ul>
        </div>
    </div>


</div>
