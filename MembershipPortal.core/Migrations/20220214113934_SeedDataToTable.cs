using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class SeedDataToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1, "Airbrushes (Powered)", "10001686" },
                    { 2292, "Nephrolepis Exaltata – Live Plants", "10006668" },
                    { 2293, "Nolina Recurvata – Live Plants", "10006669" },
                    { 2294, "Nymphaea – Live Plants", "10006670" },
                    { 2295, "Oncidium – Live Plants", "10006671" },
                    { 2296, "Orchis – Live Plants", "10006672" },
                    { 2297, "Ornithogalum Thyrsoides – Live Plants", "10006673" },
                    { 2298, "Osteospermum – Live Plants", "10006674" },
                    { 2299, "Pachira Aquatica – Live Plants", "10006681" },
                    { 2300, "Paeonia – Live Plants", "10006682" },
                    { 2301, "Papaver Nudicaule – Live Plants", "10006683" },
                    { 2291, "Narcissus – Live Plants", "10006667" },
                    { 2302, "Paphiopedilum – Live Plants", "10006684" },
                    { 2304, "Pennisetum – Live Plants", "10006686" },
                    { 2305, "Petunia – Live Plants", "10006687" },
                    { 2306, "Phalaenopsis – Live Plants", "10006688" },
                    { 2307, "Phlox – Live Plants", "10006689" },
                    { 2308, "Phoenix Roebelenii – Live Plants", "10006690" },
                    { 2309, "Platycodon Grandiflorus – Live Plants", "10006691" },
                    { 2310, "Plectranthus – Live Plants", "10006692" },
                    { 2311, "Portulaca – Live Plants", "10006693" },
                    { 2312, "Primula – Live Plants", "10006694" },
                    { 2313, "Ranunculus – Live Plants", "10006695" },
                    { 2303, "Pelargonium – Live Plants", "10006685" },
                    { 2290, "Myosotis Sylvatica – Live Plants", "10006666" },
                    { 2289, "Muscari – Live Plants", "10006665" },
                    { 2288, "Miltonia – Live Plants", "10006664" },
                    { 2265, "Hyacinthus Orientalis – Live Plants", "10006647" },
                    { 2266, "Hydrangea Macrophylla – Live Plants", "10006648" },
                    { 2267, "Impatiens – Live Plants", "10006649" },
                    { 2268, "Jasminum Polyanthum – Live Plants", "10006650" },
                    { 2269, "Kalanchoe Blossfeldiana – Live Plants", "10006651" },
                    { 2270, "Lantana Camara – Live Plants", "10006652" },
                    { 2271, "Leucanthemum – Live Plants", "10006653" },
                    { 2272, "Lewisia Cotyledon – Live Plants", "10006654" },
                    { 2273, "Lilium – Live Plants", "10006655" },
                    { 2274, "Lithodora Diffusa – Live Plants", "10006656" },
                    { 2275, "Live Plant Variety Packs", "10006657" },
                    { 2276, "Ferns – Live Plants Other", "10006676" },
                    { 2277, "Grasses – Live Plants Other", "10006677" },
                    { 2278, "Herbs – Live Plants Other", "10006678" },
                    { 2279, "Live Plants Other", "10006679" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2280, "Succulents/Cacti – Live Plants Other", "10006675" },
                    { 2281, "Water Plants – Live Plants Other", "10006680" },
                    { 2282, "Livistona Rotundifolia – Live Plants", "10006658" },
                    { 2283, "Lobelia Erinus – Live Plants", "10006659" },
                    { 2284, "Lotus Corniculatus – Live Plants", "10006660" },
                    { 2285, "Lupinus – Live Plants", "10006661" },
                    { 2286, "Mandevilla – Live Plants", "10006662" },
                    { 2287, "Medinilla Magnifica – Live Plants", "10006663" },
                    { 2314, "Rhipsalidopsis – Live Plants", "10006696" },
                    { 2315, "Rhododendron – Live Plants", "10006697" },
                    { 2316, "Rosa – Live Plants", "10006726" },
                    { 2317, "Saintpaulia – Live Plants", "10006698" },
                    { 2345, "Seedlings - Ready to Grow", "10006774" },
                    { 2346, "Seeds/Spores", "10003291" },
                    { 2347, "Shrubs/Trees", "10003714" },
                    { 2348, "Vegetables/Fungi", "10003852" },
                    { 2349, "Baby Bath Safety Products", "10000498" },
                    { 2350, "Baby Baths/Bath Chairs/Bath Cradles", "10000827" },
                    { 2351, "Baby Changing Mats", "10000822" },
                    { 2352, "Baby Changing Table", "10000501" },
                    { 2353, "Baby Potties/Training Seats", "10000821" },
                    { 2354, "Baby Sanitary Furnishings - Other", "10006797" },
                    { 2355, "Baby Sanitary Furnishings Variety Pack", "10006795" },
                    { 2356, "Baby Cot Mattress", "10000790" },
                    { 2357, "Baby Cots/Cot Beds/Bassinet", "10000789" },
                    { 2358, "Household Baby Beds/Mattresses - Other", "10006808" },
                    { 2359, "Household Baby Beds/Mattresses Variety Pack", "10006806" },
                    { 2360, "Baby Bouncing Cradles/Rocker Seats (Powered)", "10000801" },
                    { 2361, "Baby High Chair", "10000787" },
                    { 2362, "Household Baby Seating - Other", "10006811" },
                    { 2363, "Household Baby Seating Variety Pack", "10006809" },
                    { 2364, "Bed Sheets/Valances", "10002227" },
                    { 2365, "Bedding Other", "10002230" },
                    { 2366, "Blankets (Powered)", "10005197" },
                    { 2367, "Blankets/Throws (Non Powered)", "10002224" },
                    { 2344, "Plants Variety Packs", "10003305" },
                    { 2264, "Howea Forsteriana – Live Plants", "10006646" },
                    { 2343, "Zantedeschia – Live Plants", "10006725" },
                    { 2341, "Yucca – Live Plants", "10006723" },
                    { 2318, "Salvia Nemorosa – Live Plants", "10006699" },
                    { 2319, "Sansevieria Cylindrica – Live Plants", "10006700" },
                    { 2320, "Sanvitalia Procumbens – Live Plants", "10006701" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2321, "Saxifraga – Live Plants", "10006703" },
                    { 2322, "Schefflera Arboricola – Live Plants", "10006704" },
                    { 2323, "Schlumbergera – Live Plants", "10006705" },
                    { 2324, "Sedum – Live Plants", "10006706" },
                    { 2325, "Sempervivum – Live Plants", "10006707" },
                    { 2326, "Senecio Maritima – Live Plants", "10006708" },
                    { 2327, "Sinningia – Live Plants", "10006709" },
                    { 2328, "Solanum Rantonnetii – Live Plants", "10006710" },
                    { 2329, "Spathiphyllum – Live Plants", "10006711" },
                    { 2330, "Stephanotis Floribunda – Live Plants", "10006712" },
                    { 2331, "Sutera Cordata – Live Plants", "10006713" },
                    { 2332, "Tagetes – Live Plants", "10006714" },
                    { 2333, "Tillandsia Cyanea – Live Plants", "10006715" },
                    { 2334, "Tulipa – Live Plants", "10006716" },
                    { 2335, "Vanda – Live Plants", "10006717" },
                    { 2336, "Verbena – Live Plants", "10006718" },
                    { 2337, "Viola – Live Plants", "10006719" },
                    { 2338, "Vriesea – Live Plants", "10006720" },
                    { 2339, "Xburrageara – Live Plants", "10006721" },
                    { 2340, "Xcitrofortunella Microcarpa – Live Plants", "10006722" },
                    { 2342, "Zamioculcas Zamiifolia – Live Plants", "10006724" },
                    { 2263, "Hosta – Live Plants", "10006645" },
                    { 2262, "Hordeum – Live Plants", "10006644" },
                    { 2261, "Hippeastrum – Live Plants", "10006643" },
                    { 2184, "Aloe – Live Plants", "10006566" },
                    { 2185, "Alstroemeria – Live Plants", "10006567" },
                    { 2186, "Anemone Hupehensis – Live Plants", "10006568" },
                    { 2187, "Angelonia – Live Plants", "10006569" },
                    { 2188, "Anisodontea Capensis – Live Plants", "10006570" },
                    { 2189, "Anthurium – Live Plants", "10006571" },
                    { 2190, "Antirrhinum Majus – Live Plants", "10006572" },
                    { 2191, "Argyranthemum Frutescens – Live Plants", "10006573" },
                    { 2192, "Armeria Maritima – Live Plants", "10006574" },
                    { 2193, "Aster – Live Plants", "10006575" },
                    { 2194, "Astilbe – Live Plants", "10006576" },
                    { 2195, "Aubrieta Gracilis – Live Plants", "10006577" },
                    { 2196, "Begonia – Live Plants", "10006578" },
                    { 2197, "Bellis Perennis – Live Plants", "10006579" },
                    { 2198, "Bidens – Live Plants", "10006580" },
                    { 2199, "Bougainvillea – Live Plants", "10006581" },
                    { 2200, "Brachyscome Multifida – Live Plants", "10006582" },
                    { 2201, "Brassica – Live Plants", "10006583" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2202, "Bromelia – Live Plants", "10006584" },
                    { 2203, "Brugmansia – Live Plants", "10006585" },
                    { 2204, "Calathea – Live Plants", "10006586" },
                    { 2205, "Calibrachoa – Live Plants", "10006587" },
                    { 2206, "Calocephalus Brownii – Live Plants", "10006588" },
                    { 2183, "Alocasia – Live Plants", "10006565" },
                    { 2207, "Campanula Portenschlagiana – Live Plants", "10006589" },
                    { 2182, "Agapanthus – Live Plants", "10006564" },
                    { 2180, "Aechmea – Live Plants", "10006562" },
                    { 2157, "Eupatorium Rugosum – Cut Greens", "10006538" },
                    { 2158, "Fatsia Japonica – Cut Greens", "10006539" },
                    { 2159, "Gomphocarpus Fruticosus – Cut Greens", "10006540" },
                    { 2160, "Hydrangea Macrophylla – Cut Greens", "10006541" },
                    { 2161, "Ilex Verticillata – Cut Greens", "10006542" },
                    { 2162, "Leucadendron – Cut Greens", "10006543" },
                    { 2163, "Lilium – Cut Greens", "10006544" },
                    { 2164, "Matthiola Incana – Cut Greens", "10006545" },
                    { 2165, "Monstera – Cut Greens", "10006546" },
                    { 2166, "Panicum – Cut Greens", "10006548" },
                    { 2167, "Physalis Alkekengi – Cut Greens", "10006549" },
                    { 2168, "Pittosporum – Cut Greens", "10006550" },
                    { 2169, "Quercus Rubra – Cut Greens", "10006551" },
                    { 2170, "Rosa Rose/Hip – Cut Greens", "10006552" },
                    { 2171, "Ruscus Hypophyllum – Cut Greens", "10006553" },
                    { 2172, "Salix – Cut Greens", "10006554" },
                    { 2173, "Setaria Italica – Cut Greens", "10006555" },
                    { 2174, "Strelitzia Reginae – Cut Greens", "10006556" },
                    { 2175, "Symphoricarpos – Cut Greens", "10006557" },
                    { 2176, "Syringa Vulgaris – Cut Greens", "10006558" },
                    { 2177, "Thlaspi – Cut Greens", "10006559" },
                    { 2178, "Viburnum Opulus – Cut Greens", "10006560" },
                    { 2179, "Zantedeschia Aethiopica – Cut Greens", "10006561" },
                    { 2181, "Aeonium Arboreum – Live Plants", "10006563" },
                    { 2368, "Duvet Covers", "10002223" },
                    { 2208, "Canna – Live Plants", "10006590" },
                    { 2210, "Chamaedorea Elegans – Live Plants", "10006592" },
                    { 2238, "Epipremnum Pinnatum – Live Plants", "10006620" },
                    { 2239, "Euphorbia Pulcherrima – Live Plants", "10006621" },
                    { 2240, "Euryops – Live Plants", "10006622" },
                    { 2241, "Fargesia Murieliae – Live Plants", "10006623" },
                    { 2242, "Felicia Amelloides – Live Plants", "10006624" },
                    { 2243, "Festuca Glauca – Live Plants", "10006625" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2244, "Ficus Benjamina – Live Plants", "10006635" },
                    { 2245, "Fittonia – Live Plants", "10006626" },
                    { 2246, "Fuchsia – Live Plants", "10006627" },
                    { 2247, "Gardenia Jasminoides – Live Plants", "10006628" },
                    { 2248, "Gaura Lindheimeri – Live Plants", "10006629" },
                    { 2249, "Gazania – Live Plants", "10006630" },
                    { 2250, "Gentiana – Live Plants", "10006631" },
                    { 2251, "Gerbera – Live Plants", "10006632" },
                    { 2252, "Guzmania – Live Plants", "10006633" },
                    { 2253, "Gypsophila Muralis – Live Plants", "10006634" },
                    { 2254, "Hedera Helix – Live Plants", "10006636" },
                    { 2255, "Helianthus Annuus – Live Plants", "10006637" },
                    { 2256, "Helichrysum Petiolare – Live Plants", "10006638" },
                    { 2257, "Heliotropium – Live Plants", "10006639" },
                    { 2258, "Helleborus Niger – Live Plants", "10006640" },
                    { 2259, "Heuchera – Live Plants", "10006641" },
                    { 2260, "Hibiscus Rosa-Sinensis – Live Plants", "10006642" },
                    { 2237, "Echinacea Purpurea – Live Plants", "10006619" },
                    { 2209, "Celosia – Live Plants", "10006591" },
                    { 2236, "Echeveria – Live Plants", "10006618" },
                    { 2234, "Dracaena Marginata – Live Plants", "10006616" },
                    { 2211, "Chlorophytum Comosum – Live Plants", "10006593" },
                    { 2212, "Chrysanthemum – Live Plants", "10006594" },
                    { 2213, "Clivia Miniata – Live Plants", "10006595" },
                    { 2214, "Cocos Nucifera – Live Plants", "10006596" },
                    { 2215, "Codiaeum Variegatum – Live Plants", "10006597" },
                    { 2216, "Cordyline Australis – Live Plants", "10006598" },
                    { 2217, "Coreopsis Grandiflora – Live Plants", "10006599" },
                    { 2218, "Cortaderia Selloana – Live Plants", "10006600" },
                    { 2219, "Cosmos Bipinnatus – Live Plants", "10006601" },
                    { 2220, "Cuphea Hyssopifolia – Live Plants", "10006602" },
                    { 2221, "Cupressus Macrocarpa – Live Plants", "10006603" },
                    { 2222, "Curcuma Alismatifolia – Live Plants", "10006604" },
                    { 2223, "Cycas Revoluta – Live Plants", "10006605" },
                    { 2224, "Cyclamen Persicum – Live Plants", "10006606" },
                    { 2225, "Cymbidium – Live Plants", "10006607" },
                    { 2226, "Cyperus Alternifolius – Live Plants", "10006608" },
                    { 2227, "Dahlia – Live Plants", "10006609" },
                    { 2228, "Delphinium – Live Plants", "10006610" },
                    { 2229, "Dendrobium Nobile – Live Plants", "10006611" },
                    { 2230, "Dianthus – Live Plants", "10006612" },
                    { 2231, "Dicentra Spectabilis – Live Plants", "10006613" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2232, "Dieffenbachia – Live Plants", "10006614" },
                    { 2233, "Dorotheanthus Bellidiformis – Live Plants", "10006615" },
                    { 2235, "Dypsis Lutescens – Live Plants", "10006617" },
                    { 2156, "Eucalyptus Cinerea – Cut Greens", "10006537" },
                    { 2369, "Duvets/Quilts/Mattress Toppers", "10002222" },
                    { 2371, "Pillow Cases", "10002226" },
                    { 2507, "Mugs/Cups (Non Disposable)", "10002155" },
                    { 2508, "Napkin Rings", "10005210" },
                    { 2509, "Plates (Non Disposable)", "10002153" },
                    { 2510, "Salt/Pepper Shakers", "10005693" },
                    { 2511, "Salt/Pepper/Spice Mills (Non Powered)", "10002163" },
                    { 2512, "Serving Jugs/Pitchers/Decanters", "10002158" },
                    { 2513, "Serving Trays", "10002159" },
                    { 2514, "Serving/Drinking Glasses", "10002157" },
                    { 2515, "Serving/Eating/Drinking Tableware Other", "10002167" },
                    { 2516, "Serving/Eating/Drinking Tableware Variety Packs", "10002166" },
                    { 2506, "Ice/Wine Buckets", "10002162" },
                    { 2517, "Table Covers - Non Fabric/Non Textile", "10005202" },
                    { 2519, "Bottle/Can Insulators", "10005470" },
                    { 2520, "Cappuccino Creamers (Non Powered)", "10005435" },
                    { 2521, "Cocktail Shakers", "10002132" },
                    { 2522, "Grinders/Juicers/Ice Crushers (Non Powered)", "10002133" },
                    { 2523, "Household Water Testing Kits", "10005208" },
                    { 2524, "Kettles (Non Powered)", "10002129" },
                    { 2525, "Teapots/Cafetieres", "10002131" },
                    { 2526, "Water Filters/Water Filter Cartridges", "10002127" },
                    { 2527, "Water/Beverage Equipment Other", "10002135" },
                    { 2528, "Animal Scarers/Deterrents (Lawn/Garden) - Non-Powered", "10005362" },
                    { 2518, "Bottle Stoppers/Pourers", "10002130" },
                    { 2505, "Food/Beverage Warmers (Non Powered)", "10002161" },
                    { 2504, "Food Stands/Displays", "10002165" },
                    { 2503, "Food Serving Trolleys (Non Powered)", "10002160" },
                    { 2480, "Paper Filters", "10000559" },
                    { 2481, "Rolling Pins", "10002173" },
                    { 2482, "Sieves/Strainers/Colanders", "10002146" },
                    { 2483, "Skewers/Sticks", "10002174" },
                    { 2484, "Slicing/Chopping Boards", "10002147" },
                    { 2485, "Spatulas/Scoops/Ladles", "10002170" },
                    { 2486, "Tongs/Tweezers/Mallets/Mashers/Whisks", "10002171" },
                    { 2487, "Beverage Decorations/Accessories (Non Edible)", "10002128" },
                    { 2488, "Cake/Pastry Decorations/Accessories (Non Edible)", "10002149" },
                    { 2489, "Food Shaping Moulds", "10005430" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2490, "Kitchen Merchandise Variety Packs", "10002183" },
                    { 2491, "Disposable Food Bags", "10000692" },
                    { 2492, "Disposable Food Wrap", "10000693" },
                    { 2493, "Food/Beverage Storage Containers", "10002122" },
                    { 2494, "Kitchen Storage – Replacement Parts/Accessories", "10005209" },
                    { 2495, "Kitchen Storage Other", "10002124" },
                    { 2496, "Kitchen Storage Racks/Stands/Holders/Dispensers", "10002121" },
                    { 2497, "Kitchen Storage Variety Packs", "10002123" },
                    { 2498, "String/Ties", "10000541" },
                    { 2499, "Bowls (Non Disposable)", "10002154" },
                    { 2500, "Cutlery (Non Disposable)", "10002156" },
                    { 2501, "Disposable Tableware / Disposable Table Covers", "10000635" },
                    { 2502, "Egg Cups", "10005427" },
                    { 2529, "Animal Scarers/Deterrents (Lawn/Garden) – Powered", "10006853" },
                    { 2530, "Fungicides", "10004109" },
                    { 2531, "Lawn/Garden Chemicals/Treatments Other", "10003240" },
                    { 2532, "Lawn/Garden Chemicals/Treatments Variety Packs", "10003239" },
                    { 2560, "Electric Fence/Radio Fences", "10003283" },
                    { 2561, "Fence Net/Mesh", "10003281" },
                    { 2562, "Fence Panels/Boards", "10003277" },
                    { 2563, "Fence Posts/Rails", "10003278" },
                    { 2564, "Fence Stays/Braces", "10003279" },
                    { 2565, "Garden Borders/Edges", "10003280" },
                    { 2566, "Gates (Non Powered)", "10003286" },
                    { 2567, "Gates (Powered)", "10003287" },
                    { 2568, "Lawn/Garden Fencing Accessories", "10005678" },
                    { 2569, "Lawn/Garden Fencing Other", "10003289" },
                    { 2570, "Lawn/Garden Fencing Variety Packs", "10003288" },
                    { 2571, "Razor/Barbed Wire Fencing", "10003285" },
                    { 2572, "Trellising", "10003284" },
                    { 2573, "Plant Supports/Stakes", "10005220" },
                    { 2574, "Variety Planters – Box/Pot", "10003854" },
                    { 2575, "Garden Benches", "10003248" },
                    { 2576, "Garden Chairs", "10003242" },
                    { 2577, "Garden Display Units", "10003316" },
                    { 2578, "Garden Footrests", "10003246" },
                    { 2579, "Garden Kneelers/Seats", "10003406" },
                    { 2580, "Garden Loungers", "10003243" },
                    { 2581, "Garden Ornaments/Plaques", "10005719" },
                    { 2582, "Garden Swing Benches", "10003249" },
                    { 2559, "Lawn/Garden Equipment Other", "10003872" },
                    { 2479, "Openers – Kitchen", "10002175" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2558, "Lawn/Garden Equipment Accessories", "10003352" },
                    { 2556, "Lawn Rollers (Non Powered)", "10003394" },
                    { 2533, "Lawn/Garden Insecticides / Pesticides", "10006732" },
                    { 2534, "Leaf Shine/Plant Cleaner", "10005360" },
                    { 2535, "Plant Growth Regulators", "10006733" },
                    { 2536, "Plant/Soil Fertilizer/Food", "10003234" },
                    { 2537, "Pool/Water Feature Chemicals/Treatments", "10003221" },
                    { 2538, "Seed Protection/ Mordants", "10006734" },
                    { 2539, "Weed-Killer/ Herbicide", "10003227" },
                    { 2540, "Barbecues (Non Powered)", "10003328" },
                    { 2541, "Barbecues (Powered)", "10003327" },
                    { 2542, "Greenhouse Heaters/Ventilators", "10005369" },
                    { 2543, "Grill Islands (Lawn/Garden)", "10003330" },
                    { 2544, "Lawn/Garden Cooking/Heating Appliances Other", "10003335" },
                    { 2545, "Lawn/Garden Cooking/Heating Appliances Replacement Parts/Accessories", "10003336" },
                    { 2546, "Lawn/Garden Cooking/Heating Appliances Variety Packs", "10003334" },
                    { 2547, "Outdoor Heaters (Non Powered)", "10003324" },
                    { 2548, "Outdoor Heaters (Powered)", "10003323" },
                    { 2549, "Smokers – Cooking (Non Powered)", "10006742" },
                    { 2550, "Smokers – Cooking (Powered)", "10006741" },
                    { 2551, "Warmers/Drawers (Lawn/Garden)", "10003332" },
                    { 2552, "Garden Carts (Powered)", "10003376" },
                    { 2553, "Garden Tractors", "10004102" },
                    { 2554, "Lawn Mowers/Rakers (Non Powered)", "10003387" },
                    { 2555, "Lawn Mowers/Rakers (Powered)", "10003353" },
                    { 2557, "Lawn Rollers (Powered)", "10003841" },
                    { 2478, "Multifunction Kitchen Tools", "10002176" },
                    { 2477, "Mincers/Choppers/Ricers/Pasta Makers (Non Powered)", "10002148" },
                    { 2476, "Kitchen Slicers/Graters/Cutters", "10002172" },
                    { 2399, "Household/Office Seating Variety Packs", "10002200" },
                    { 2400, "Household/Office Sofa Beds", "10002196" },
                    { 2401, "Household/Office Sofas (Non Powered)", "10002195" },
                    { 2402, "Household/Office Sofas (Powered)", "10002194" },
                    { 2403, "Inflatable Seating", "10002198" },
                    { 2404, "Drawers", "10002117" },
                    { 2405, "Filing Cabinets", "10002185" },
                    { 2406, "Household Organisers/Tidies", "10002189" },
                    { 2407, "Household/Office Bar Counters", "10005810" },
                    { 2408, "Household/Office Boxes/Baskets", "10002187" },
                    { 2409, "Household/Office Cupboards/Display Cabinets", "10005199" },
                    { 2410, "Household/Office Partitions/Screens", "10002190" },
                    { 2411, "Household/Office Shelving Units", "10002184" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2412, "Household/Office Storage/Display Furniture – Replacement Parts/Components", "10005098" },
                    { 2413, "Household/Office Storage/Display Furniture Other", "10003790" },
                    { 2414, "Household/Office Wardrobes/Lockers", "10002118" },
                    { 2415, "Storage Rails/Holders", "10002188" },
                    { 2416, "Universal Entertainment Units", "10002186" },
                    { 2417, "Universal Turntables", "10005743" },
                    { 2418, "Worktops/Countertops", "10006731" },
                    { 2419, "Household/Office Desks/Workstations", "10002203" },
                    { 2420, "Household/Office Tables", "10002202" },
                    { 2421, "Household/Office Tables/Desks – Replacement Parts/Components", "10005095" },
                    { 2398, "Household/Office Seating Other", "10002201" },
                    { 2422, "Household/Office Tables/Desks Other", "10002205" },
                    { 2397, "Household/Office Foot Rests", "10002199" },
                    { 2395, "Household/Office Chairs/Stools (Non Powered)", "10002193" },
                    { 2372, "Pillows", "10002225" },
                    { 2373, "Fabric/Textile Furnishings Variety Packs", "10003813" },
                    { 2374, "Curtains", "10002214" },
                    { 2375, "Cushions", "10002217" },
                    { 2376, "Fabric/Textile Towels", "10002219" },
                    { 2377, "Furnishing Covers/Cloths – Detachable", "10002216" },
                    { 2378, "Furnishing Floor Rugs/Mats – Detachable", "10002218" },
                    { 2379, "Household/Office Fabric/Textile Furnishing Variety Packs", "10002220" },
                    { 2380, "Household/Office Fabric/Textile Furnishings Other", "10002221" },
                    { 2381, "Window Blinds", "10002215" },
                    { 2382, "Display Stand", "10006330" },
                    { 2383, "Household Adjustable Beds (Non Powered)", "10002209" },
                    { 2384, "Household Adjustable Beds (Powered)", "10002208" },
                    { 2385, "Household Bed Frames/Bedsteads", "10002207" },
                    { 2386, "Household Beds – Replacement Parts/Components", "10005096" },
                    { 2387, "Household Beds/Mattresses Other", "10002212" },
                    { 2388, "Household Inflatable Beds/Water Beds", "10002211" },
                    { 2389, "Household Mattresses", "10002210" },
                    { 2390, "Furniture Castors/Pads/Slides", "10005437" },
                    { 2391, "Shelf Grip Liner/Contact Paper", "10005254" },
                    { 2392, "Household/Office Furniture Variety Packs", "10003814" },
                    { 2393, "Bean Bags/Pouffes/Ottomans", "10002197" },
                    { 2394, "Household/Office Chairs – Replacement Parts/Components", "10005097" },
                    { 2396, "Household/Office Chairs/Stools (Powered)", "10002192" },
                    { 2370, "Mattress/Pillow/Duvet Protectors", "10002228" },
                    { 2423, "Clocks", "10002252" },
                    { 2425, "Decorative Banners/Flags", "10005816" },
                    { 2453, "Cookware/Bakeware Other", "10002152" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2454, "Hob Pots/Pans", "10002144" },
                    { 2455, "Kitchen Cookware/Bakeware Variety Packs", "10002151" },
                    { 2456, "Disposable Food Containers", "10006331" },
                    { 2457, "Disposable Food Containers Other", "10006333" },
                    { 2458, "Cooking Timers (Non Powered)", "10002136" },
                    { 2459, "Food Measuring Equipment Other", "10002142" },
                    { 2460, "Food Thermometers", "10002140" },
                    { 2461, "Food Volume Measuring Equipment", "10002139" },
                    { 2462, "Kitchen Scales (Non Powered)", "10002143" },
                    { 2463, "Baby Cutlery (Non Disposable)", "10006801" },
                    { 2464, "Baby Feeding Aids (Non Powered)", "10000493" },
                    { 2465, "Cookie Guns/Food Decorating Syringes (Non Powered)", "10005434" },
                    { 2466, "Corers/Peelers", "10002169" },
                    { 2467, "Flour/Sugar Shakers", "10005694" },
                    { 2468, "Food Funnels", "10005429" },
                    { 2469, "Food Preparation Bowls", "10005701" },
                    { 2470, "Food Preparation Brushes/Oil Pumps/Baster", "10005426" },
                    { 2471, "Food Preparation Equipment Other", "10002178" },
                    { 2472, "Gloves", "10005894" },
                    { 2473, "Kitchen Knife Sharpeners (Non Powered)", "10005201" },
                    { 2474, "Kitchen Knives/Cleavers", "10002168" },
                    { 2475, "Kitchen Scissors", "10000542" },
                    { 2452, "Cookware/Bakeware Accessories/Replacement Parts", "10005675" },
                    { 2424, "Clocks – Replacement Parts", "10004101" },
                    { 2451, "Cookware (Disposable)", "10000554" },
                    { 2449, "Baby Feeding Other", "10000825" },
                    { 2426, "Ornamental Furnishings Variety Packs", "10003816" },
                    { 2427, "Artificial Flowers/Plants/Trees", "10002232" },
                    { 2428, "Candle Holders/Accessories", "10002249" },
                    { 2429, "Candles", "10000555" },
                    { 2430, "Decorative Magnets/Stickers/Window Clings", "10002234" },
                    { 2431, "Ornament Accessories", "10005692" },
                    { 2432, "Ornaments", "10002231" },
                    { 2433, "Ornaments Variety Packs", "10002238" },
                    { 2434, "Seasonal Decorations (Non Powered)", "10002236" },
                    { 2435, "Seasonal Decorations (Powered)", "10002237" },
                    { 2436, "Sun/Dream Catchers/Windchimes", "10002235" },
                    { 2437, "Vases", "10002233" },
                    { 2438, "Mirrors", "10002245" },
                    { 2439, "Paintings", "10002240" },
                    { 2440, "Photographs", "10002243" },
                    { 2441, "Picture Frames", "10002246" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2442, "Picture/Mirrors/Frames Other", "10002248" },
                    { 2443, "Posters/Prints", "10002241" },
                    { 2444, "Baby Feeding – Bottles", "10000491" },
                    { 2445, "Baby Feeding – Replacement Parts", "10000823" },
                    { 2446, "Baby Feeding – Tableware", "10000490" },
                    { 2447, "Baby Feeding – Teats", "10000724" },
                    { 2448, "Baby Feeding Accessories", "10000492" },
                    { 2450, "Bakeware/Ovenware/Grillware (Non Disposable)", "10002150" },
                    { 2155, "Dracaena Sanderiana – Cut Greens", "10006536" },
                    { 2154, "Cut Green Variety Packs", "10006535" },
                    { 2153, "Cut Greens Other", "10006547" },
                    { 1860, "Drug Administration – Accessories", "10000457" },
                    { 1861, "Drug Administration – Replacement Parts", "10000912" },
                    { 1862, "Drug Administration Variety Packs", "10000681" },
                    { 1863, "Enteral Feeding Equipment Variety Packs", "10000921" },
                    { 1864, "Enteral Feeding Nutrition Bags/Containers", "10000900" },
                    { 1865, "Enteral Feeding Tubes", "10000901" },
                    { 1866, "First Aid – Accessories", "10000449" },
                    { 1867, "First Aid – Dressings/Bandages/Plaster", "10000448" },
                    { 1868, "First Aid – Sling/Support", "10000450" },
                    { 1869, "First Aid Other", "10000908" },
                    { 1859, "Drug Administration", "10000456" },
                    { 1870, "Ice/Heated Pack", "10000451" },
                    { 1872, "Flower Remedies", "10000861" },
                    { 1873, "Flower/Homoeopathic/Homeopathic Remedies Variety Packs", "10000862" },
                    { 1874, "Homoeopathic/Homeopathic Remedies – Individual Ingredients", "10000859" },
                    { 1875, "Foot Care/Hygiene Aids", "10000489" },
                    { 1876, "Foot/Leg Care/Treatments Other", "10000907" },
                    { 1877, "Foot/Leg Care/Treatments Variety Packs", "10000685" },
                    { 1878, "Medicated/Orthopaedic Footwear", "10000488" },
                    { 1879, "Therapeutic Hosiery", "10000474" },
                    { 1880, "Antacids/Indigestion/Flatulence Remedies", "10000863" },
                    { 1881, "Diarrhoea Remedies", "10000864" },
                    { 1871, "Poison Removal/Treatment Products", "10000909" },
                    { 1858, "Rectal Medication", "10000848" },
                    { 1857, "Intimate Lubrication", "10000923" },
                    { 1856, "Enemas/Douches", "10000851" },
                    { 1833, "Carbon Dioxide Gas", "10006407" },
                    { 1834, "Nitrogen Gas", "10006408" },
                    { 1835, "Technical Gases Other", "10006410" },
                    { 1836, "Barrier Contraception Other", "10000838" },
                    { 1837, "Condoms", "10000460" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1838, "Diaphragms/Cervical Caps", "10000461" },
                    { 1839, "Spermicides", "10000462" },
                    { 1840, "Family Planning Variety Packs", "10000675" },
                    { 1841, "Hormonal Contraception", "10000463" },
                    { 1842, "Intra-uterine Contraception", "10000464" },
                    { 1843, "Dietary Aid – Appetite/Fat Control", "10000465" },
                    { 1844, "Dietary Aid – Meal Replacement", "10000466" },
                    { 1845, "Dietary Aids Other", "10000841" },
                    { 1846, "Dietary Aids Variety Packs", "10000650" },
                    { 1847, "Energy/Stimulant Products", "10000917" },
                    { 1848, "Energy/Stimulant Products Other", "10000918" },
                    { 1849, "Nutritional Supplements", "10000468" },
                    { 1850, "Vitamins/Minerals", "10000467" },
                    { 1851, "Vitamins/Minerals/Nutritional Supplements Variety Packs", "10000651" },
                    { 1852, "Baby Treatments", "10000500" },
                    { 1853, "Pacifiers/Teething Rings", "10000504" },
                    { 1854, "Bladder/Genital/Rectal Products Other", "10000849" },
                    { 1855, "Cystitis Products", "10000847" },
                    { 1882, "Gastrointestinal Remedy Products Other", "10000865" },
                    { 1883, "General/Multi-use Gastrointestinal Remedies", "10000870" },
                    { 1884, "Laxatives", "10000866" },
                    { 1885, "Nausea Remedies", "10000868" },
                    { 1913, "Optic Appliances – Spectacle Frames", "10000639" },
                    { 1914, "Optic Appliances – Spectacle Lenses", "10000638" },
                    { 1915, "Optic Appliances – Spectacles – Ready To Wear", "10000528" },
                    { 1916, "Optic Appliances – Sunglasses – Ready To Wear", "10000637" },
                    { 1917, "Optic Appliances Care – Contact Lenses", "10000527" },
                    { 1918, "Optic Appliances Care – Spectacles", "10000688" },
                    { 1919, "Sensory Organs Care/Treatments Variety Packs", "10000687" },
                    { 1920, "Acne/Rosacea Treatments", "10000903" },
                    { 1921, "Anti-fungal Products", "10000890" },
                    { 1922, "General/Multi Purpose Skin/Scalp Treatments", "10000891" },
                    { 1923, "Hand Sanitizers / Antiseptics", "10000885" },
                    { 1924, "Parasite Infestation Equipment (Non Powered)", "10000892" },
                    { 1925, "Parasite Infestation Treatments", "10000886" },
                    { 1926, "Psoriasis/Eczema/Dry Skin/Scalp Treatments", "10000887" },
                    { 1927, "Skin/Scalp Treatment Products Variety Packs", "10000905" },
                    { 1928, "Wart/Verruca/Corn/Callus Treatments", "10000904" },
                    { 1929, "Sleeping Aids", "10000872" },
                    { 1930, "Sleeping/Stress Relieving Products Variety Packs", "10000874" },
                    { 1931, "Travel Sickness Preventatives – Medicinal", "10000894" },
                    { 1932, "Travel Sickness Preventatives – Non Medicinal", "10000895" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1933, "Travel Sickness Products Variety Packs", "10000896" },
                    { 1934, "Diagnostic Monitors Other", "10000843" },
                    { 1935, "Home Diagnostic Monitors", "10000455" },
                    { 1912, "Optic Appliances – Contact Lenses", "10000529" },
                    { 1832, "Solid Fuels", "10005266" },
                    { 1911, "Hearing Aids", "10000487" },
                    { 1909, "Ear Preparations", "10000525" },
                    { 1886, "Worming Preparations", "10000867" },
                    { 1887, "Habit Treatment", "10000459" },
                    { 1888, "Habit Treatment Variety Packs", "10000690" },
                    { 1889, "Oral/Mouth Treatments", "10002423" },
                    { 1890, "Arthritic/Rheumatic/Muscular Pain Relief", "10000855" },
                    { 1891, "General/Multi-use Pain Relief", "10000856" },
                    { 1892, "Headache/Migraine Pain Relief", "10000857" },
                    { 1893, "Pain Relief (Powered)", "10000853" },
                    { 1894, "Pain Relief Products Other", "10000854" },
                    { 1895, "Disability Aids", "10000458" },
                    { 1896, "Personal Aids Other", "10000915" },
                    { 1897, "Personal Repellents", "10000570" },
                    { 1898, "Allergy Prevention/Relief/Antihistamines", "10000881" },
                    { 1899, "Chest Rubs", "10000875" },
                    { 1900, "Cold/Cough Remedies", "10000876" },
                    { 1901, "Decongestants Other", "10000882" },
                    { 1902, "Humidifiers/Vaporisers (Non Powered)", "10000883" },
                    { 1903, "Humidifiers/Vaporisers (Powered)", "10000916" },
                    { 1904, "Inhalers/Nebulisers/Respirators (Non Powered)", "10000877" },
                    { 1905, "Inhalers/Nebulisers/Respirators (Powered)", "10000878" },
                    { 1906, "Nasal Strips/Sprays", "10000879" },
                    { 1907, "Respiratory/Allergy Products Other", "10000920" },
                    { 1908, "Throat Remedies", "10000880" },
                    { 1910, "Eye Preparations", "10000526" },
                    { 1831, "Liquid Fuels", "10005263" },
                    { 1830, "Gel Fuels", "10005265" },
                    { 1829, "Gas Fuels", "10005264" },
                    { 1752, "Horseradish", "10006124" },
                    { 1753, "Jerusalem Artichokes", "10006125" },
                    { 1754, "Jicama Bean", "10006344" },
                    { 1755, "Lilac Tannia", "10006109" },
                    { 1756, "Lotus Root", "10006364" },
                    { 1757, "Name Mapuey", "10006351" },
                    { 1758, "Okra (Chinese)", "10006366" },
                    { 1759, "Parsley Root (Hamburg)", "10006127" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1760, "Parsnips", "10006126" },
                    { 1761, "Potatoes", "10006104" },
                    { 1762, "Radishes", "10006114" },
                    { 1763, "Salsify", "10006367" },
                    { 1764, "Scorzonera", "10006200" },
                    { 1765, "Sweet Potatoes", "10006111" },
                    { 1766, "Taro", "10006107" },
                    { 1767, "Turnip Rooted Chervil", "10006418" },
                    { 1768, "White Radish (Daikon)", "10006417" },
                    { 1769, "White Tannia", "10006110" },
                    { 1770, "Yams", "10006112" },
                    { 1771, "Mamey", "10006365" },
                    { 1772, "Sapodillo", "10006368" },
                    { 1773, "Sapote (Black)", "10006369" },
                    { 1774, "Sapote (White)", "10006370" },
                    { 1751, "Gobo Root/Burdock", "10006363" },
                    { 1775, "Water Chestnuts", "10006372" },
                    { 1750, "Ginseng", "10006833" },
                    { 1748, "Celeriac", "10006123" },
                    { 1725, "Sprouts", "10006260" },
                    { 1726, "Carobs", "10005986" },
                    { 1727, "Corn (Indian)", "10006337" },
                    { 1728, "Okra", "10006148" },
                    { 1729, "Sweetcorn", "10006147" },
                    { 1730, "Black Eyed Peas", "10006825" },
                    { 1731, "Lentils", "10006454" },
                    { 1732, "Peas", "10005984" },
                    { 1733, "Snow Peas", "10006270" },
                    { 1734, "Sugar Snap Peas", "10005985" },
                    { 1735, "Winged Pea", "10006455" },
                    { 1736, "Chilli Peppers", "10006102" },
                    { 1737, "Elongated Sweet Peppers (Pointed)", "10006100" },
                    { 1738, "Flat Sweet Peppers (Tomato Peppers)", "10006192" },
                    { 1739, "Pepper Variety Packs", "10006195" },
                    { 1740, "Square Sweet Peppers (Blunt)", "10006190" },
                    { 1741, "Square Tapering Sweet Peppers (Peg Top)", "10006191" },
                    { 1742, "Arracacha", "10006335" },
                    { 1743, "Arrowroot", "10006416" },
                    { 1744, "Beetroot", "10006121" },
                    { 1745, "Black Radishes", "10006115" },
                    { 1746, "Carrots", "10006122" },
                    { 1747, "Cassava", "10006108" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1749, "Ginger", "10006113" },
                    { 1936, "Diagnostic Tests Other", "10000844" },
                    { 1776, "Antroewa", "10006452" },
                    { 1778, "Naranjilla/Lulo", "10006760" },
                    { 1806, "Athletic Footwear – General Purpose", "10001070" },
                    { 1807, "Athletic Footwear – Specialist", "10001071" },
                    { 1808, "Footwear – Replacement Parts/Accessories", "10000433" },
                    { 1809, "Footwear Accessories Variety Packs", "10000700" },
                    { 1810, "Footwear Inserts", "10001074" },
                    { 1811, "Shoe Cleaning/Care Preparations", "10000400" },
                    { 1812, "Shoe Colour/Dyes", "10000432" },
                    { 1813, "Boots – General Purpose", "10001076" },
                    { 1814, "Shoes – General Purpose", "10001077" },
                    { 1815, "Indoor Footwear – Fully Enclosed Uppers", "10001078" },
                    { 1816, "Indoor Footwear – Partially Enclosed Uppers", "10001079" },
                    { 1817, "Safety/Protective Occupational Overshoes", "10001081" },
                    { 1818, "Safety/Protective Occupational Shoes", "10001082" },
                    { 1819, "Safety/Protective/Occupational Boots", "10001080" },
                    { 1820, "Fuel Pumps (Non Powered)", "10005256" },
                    { 1821, "Fuel Pumps (Powered)", "10005257" },
                    { 1822, "Gas Fuel Bottles/Canisters (Empty)", "10005258" },
                    { 1823, "Liquid Fuel Bottles/Containers (Empty)", "10005306" },
                    { 1824, "Fuel Additives", "10005255" },
                    { 1825, "Fuels/Fuel Additives Variety Packs", "10005262" },
                    { 1826, "Firelighting Tools/Matches", "10000543" },
                    { 1827, "Firelighting Tools/Matches Accessories", "10006842" },
                    { 1828, "Fuels/Ignition Aids Variety Packs", "10000703" },
                    { 1805, "Vegetables – Unprepared/Unprocessed (Fresh) Variety Packs", "10006171" },
                    { 1777, "Aubergines", "10006128" },
                    { 1804, "Tomatoes Variety Packs", "10006166" },
                    { 1802, "Tomatoes – Ribbed", "10006164" },
                    { 1779, "Pepino", "10006453" },
                    { 1780, "Tamarillo", "10006358" },
                    { 1781, "Tomatillos", "10006451" },
                    { 1782, "Asparagus", "10006129" },
                    { 1783, "Bamboo Shoots", "10006137" },
                    { 1784, "Cardoons", "10006135" },
                    { 1785, "Celery", "10006131" },
                    { 1786, "Fennel (subspecies azoricum)", "10006272" },
                    { 1787, "Globe Artichokes", "10006130" },
                    { 1788, "Leek", "10006133" },
                    { 1789, "Palm Hearts", "10006136" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1790, "Rhubarb", "10006134" },
                    { 1791, "Sweet Potato Stems", "10006835" },
                    { 1792, "Aloe Vera", "10006360" },
                    { 1793, "Sugar Cane", "10006371" },
                    { 1794, "Agretti", "10006461" },
                    { 1795, "Glasswort", "10006460" },
                    { 1796, "Sea Kale", "10006458" },
                    { 1797, "Sea Lavender", "10006459" },
                    { 1798, "Tidal Sea Vegetables Other", "10006262" },
                    { 1799, "Cherry Tomatoes – Oblong", "10006161" },
                    { 1800, "Cherry Tomatoes – Round", "10006162" },
                    { 1801, "Tomatoes – Oblong", "10006163" },
                    { 1803, "Tomatoes – Round", "10006165" },
                    { 1937, "Home Diagnostic Products – Accessories", "10000454" },
                    { 1938, "Home Diagnostic Tests", "10000453" },
                    { 1939, "Thermometers", "10000452" },
                    { 2076, "Lilium", "10006861" },
                    { 2077, "Muscari", "10006855" },
                    { 2078, "Narcissus", "10006862" },
                    { 2079, "Tulipa", "10006863" },
                    { 2080, "Zantedeschia", "10006865" },
                    { 2081, "Agapanthus – Cut Flowers", "10006462" },
                    { 2082, "Alchemilla Mollis – Cut Flowers", "10006463" },
                    { 2083, "Alstroemeria – Cut Flowers", "10006464" },
                    { 2084, "Anemone Coronaria – Cut Flowers", "10006465" },
                    { 2085, "Anthurium – Cut Flowers", "10006466" },
                    { 2086, "Antirrhinum Majus – Cut Flowers", "10006467" },
                    { 2087, "Aster – Cut Flowers", "10006468" },
                    { 2088, "Bouvardia – Cut Flowers", "10006469" },
                    { 2089, "Celosia Argentea – Cut Flowers", "10006470" },
                    { 2090, "Chamelaucium Other – Cut Flowers", "10006471" },
                    { 2091, "Chamelaucium Uncinatum – Cut Flowers", "10006472" },
                    { 2092, "Chrysanthemum – Cut Flowers", "10006473" },
                    { 2093, "Cut Flowers Other", "10006502" },
                    { 2094, "Cymbidium – Cut Flowers", "10006474" },
                    { 2095, "Dahlia – Cut Flowers", "10006476" },
                    { 2096, "Delphinium – Cut Flowers", "10006477" },
                    { 2097, "Dianthus Barbatus – Cut Flowers", "10006478" },
                    { 2098, "Dianthus Other – Cut Flowers", "10006479" },
                    { 2075, "Iris", "10006859" },
                    { 2099, "Eryngium – Cut Flowers", "10006480" },
                    { 2074, "Hyacinthus Orientalis", "10006858" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2072, "Gladiolus", "10006857" },
                    { 2049, "Raclettes (Powered)", "10001972" },
                    { 2050, "Rice Cookers/Steamers", "10001977" },
                    { 2051, "Rotisseries/Roasters (Powered)", "10001974" },
                    { 2052, "Sandwich/Waffle Makers", "10001970" },
                    { 2053, "Slow Cookers/Hot Pots", "10001975" },
                    { 2054, "Small Cooking Appliances Other", "10002034" },
                    { 2055, "Small Cooking Appliances Replacement Parts/Accessories", "10002035" },
                    { 2056, "Tajines (Powered)", "10001987" },
                    { 2057, "Toaster Ovens", "10001968" },
                    { 2058, "Toasters", "10001967" },
                    { 2059, "Warming Trays (Powered)", "10005359" },
                    { 2060, "Woks (Powered)", "10001982" },
                    { 2061, "Small Domestic Appliances - Other", "10006894" },
                    { 2062, "Water Dispensers – Tabletop", "10003713" },
                    { 2063, "Alstroemeria Bouquets", "10006768" },
                    { 2064, "Chrysanthemum Bouquets", "10006767" },
                    { 2065, "Mini Carnation Bouquets", "10006765" },
                    { 2066, "Other Bouquets", "10006771" },
                    { 2067, "Tropical Flowers Bouquets", "10006769" },
                    { 2068, "Allium", "10006864" },
                    { 2069, "Bulbs/Corms/Rhizomes/Tubers - Other", "10003290" },
                    { 2070, "Crocus", "10006860" },
                    { 2071, "Dahlia", "10006856" },
                    { 2073, "Hippeastrum", "10006854" },
                    { 2048, "Pressure Cookers", "10001976" },
                    { 2100, "Eustoma Russellianum – Cut Flowers", "10006481" },
                    { 2102, "Gerbera – Cut Flowers", "10006483" },
                    { 2130, "Syringa Vulgaris – Cut Flowers", "10006512" },
                    { 2131, "Tanacetum Parthenium – Cut Flowers", "10006513" },
                    { 2132, "Trachelium Caeruleum – Cut Flowers", "10006514" },
                    { 2133, "Tulipa – Cut Flowers", "10006515" },
                    { 2134, "Vanda – Cut Flowers", "10006516" },
                    { 2135, "Veronica – Cut Flowers", "10006517" },
                    { 2136, "Viburnum Opulus – Cut Flowers", "10006518" },
                    { 2137, "Zantedeschia Aethiopica – Cut Flowers", "10006519" },
                    { 2138, "Zantedeschia Other – Cut Flowers", "10006520" },
                    { 2139, "Agapanthus – Cut Greens", "10006521" },
                    { 2140, "Anthurium – Cut Greens", "10006522" },
                    { 2141, "Asparagus Setaceus – Cut Greens", "10006523" },
                    { 2142, "Asparagus Umbellatus – Cut Greens", "10006524" },
                    { 2143, "Aspidistra Elatior – Cut Greens", "10006525" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2144, "Astilbe Other – Cut Greens", "10006526" },
                    { 2145, "Brassica Oleracea – Cut Greens", "10006527" },
                    { 2146, "Carthamus Tinctorius – Cut Greens", "10006528" },
                    { 2147, "Corylus Avellana – Cut Greens", "10006529" },
                    { 2148, "Crocosmia – Cut Greens", "10006530" },
                    { 2149, "Cucumis – Cut Greens", "10006531" },
                    { 2150, "Cucurbita Maxima – Cut Greens", "10006532" },
                    { 2151, "Cucurbita Other – Cut Greens", "10006533" },
                    { 2152, "Cucurbita Pepo – Cut Greens", "10006534" },
                    { 2129, "Strelitzia Reginae – Cut Flowers", "10006511" },
                    { 2101, "Freesia – Cut Flowers", "10006482" },
                    { 2128, "Solidago – Cut Flowers", "10006510" },
                    { 2126, "Ranunculus Other – Cut Flowers", "10006508" },
                    { 2103, "Gladiolus – Cut Flowers", "10006484" },
                    { 2104, "Gypsophila Paniculata – Cut Flowers", "10006485" },
                    { 2105, "Helianthus Annuus – Cut Flowers", "10006486" },
                    { 2106, "Hippeastrum – Cut Flowers", "10006487" },
                    { 2107, "Hyacinthus Orientalis – Cut Flowers", "10006488" },
                    { 2108, "Hydrangea Macrophylla – Cut Flowers", "10006489" },
                    { 2109, "Hypericum Androsaemum – Cut Flowers", "10006490" },
                    { 2110, "Hypericum Other – Cut Flowers", "10006491" },
                    { 2111, "Hypericum X Inodorum – Cut Flowers", "10006492" },
                    { 2112, "Ilex Verticillata – Cut Flowers", "10006493" },
                    { 2113, "Iris – Cut Flowers", "10006494" },
                    { 2114, "Lilium Longiflorum – Cut Flowers", "10006495" },
                    { 2115, "Lilium Other – Cut Flowers", "10006496" },
                    { 2116, "Limonium Other – Cut Flowers", "10006497" },
                    { 2117, "Limonium Sinuatum – Cut Flowers", "10006498" },
                    { 2118, "Matthiola Incana – Cut Flowers", "10006499" },
                    { 2119, "Narcissus – Cut Flowers", "10006500" },
                    { 2120, "Ornithogalum Saundersiae – Cut Flowers", "10006501" },
                    { 2121, "Paeonia – Cut Flowers", "10006503" },
                    { 2122, "Phalaenopsis – Cut Flowers", "10006504" },
                    { 2123, "Phlox – Cut Flowers", "10006505" },
                    { 2124, "Pittosporum – Cut Flowers", "10006506" },
                    { 2125, "Ranunculus Asiaticus – Cut Flowers", "10006507" },
                    { 2127, "Rosa – Cut Flowers", "10006509" },
                    { 2583, "Garden Tables", "10003245" },
                    { 2047, "Popcorn Makers", "10001984" },
                    { 2045, "Pasta Cookers", "10001979" },
                    { 1968, "Wine Chillers", "10001939" },
                    { 1969, "Hostess Trolleys (Powered)", "10001956" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1970, "Warming Appliances Other", "10001957" },
                    { 1971, "Warming Drawers", "10001955" },
                    { 1972, "Food Waste Disposers", "10001929" },
                    { 1973, "Trash Compactors", "10001928" },
                    { 1974, "Waste Disposing/Compacting Appliances Other", "10001930" },
                    { 1975, "Cleaning Appliances Other", "10002032" },
                    { 1976, "Cleaning Appliances Replacement Parts/Accessories", "10002033" },
                    { 1977, "Disinfecting Cabinet", "10006220" },
                    { 1978, "Floor Polishers/Shampoo Cleaner", "10002030" },
                    { 1979, "Shoe Cleaners/Polishers", "10003711" },
                    { 1980, "Steam Cleaners", "10002031" },
                    { 1981, "Sweepers (Non Powered)", "10005811" },
                    { 1982, "Vacuum Cleaner Bags", "10005762" },
                    { 1983, "Vacuum Cleaners", "10002028" },
                    { 1984, "Baby Feeding Aids (Powered)", "10000820" },
                    { 1985, "Butter Makers (Powered)", "10002015" },
                    { 1986, "Can Openers (Powered)", "10002000" },
                    { 1987, "Candyfloss Machines", "10002019" },
                    { 1988, "Carbonated Drinks Makers", "10002016" },
                    { 1989, "Chocolate Fountains (Powered)", "10005690" },
                    { 1990, "Coffee Bean Roasters", "10006852" },
                    { 1967, "Refrigerators", "10003694" },
                    { 1991, "Coffee Grinders (Powered)", "10002006" },
                    { 1966, "Refrigerator/Freezers", "10003695" },
                    { 1964, "Refrigerating/Freezing Appliances Other", "10001941" },
                    { 1940, "Home Diagnostics Variety Packs", "10000647" },
                    { 1941, "Pharmaceutical Drugs", "10005845" },
                    { 1942, "Veterinary Pharmaceuticals", "10000514" },
                    { 1944, "Kitchen Washing Appliances Other", "10001965" },
                    { 1945, "Kitchen Washing Appliances Replacement Parts/Accessories", "10001966" },
                    { 1946, "Cooker Hoods", "10005322" },
                    { 1947, "Hobs/Cooktops", "10001951" },
                    { 1948, "Major Cooking Appliances Other", "10001953" },
                    { 1949, "Major Cooking Appliances Replacement Parts/Accessories", "10001954" },
                    { 1950, "Microwave Ovens", "10001952" },
                    { 1951, "Ovens", "10001950" },
                    { 1952, "Range Cookers/Stoves (Oven/Hob/Cook Top Combined)", "10003690" },
                    { 1953, "Steam Ovens", "10003691" },
                    { 1954, "Clothes Washers", "10001959" },
                    { 1955, "Combination Clothes Washer/Dryers", "10001961" },
                    { 1956, "Major Laundry Appliances Other", "10001962" },
                    { 1957, "Major Laundry Appliances Replacement Parts/Accessories", "10001963" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1958, "Spin/Tumble Dryers", "10003692" },
                    { 1959, "Water Dispensers – Freestanding", "10003712" },
                    { 1960, "Beverage Chillers Other", "10003710" },
                    { 1961, "Coolers/Heaters", "10001940" },
                    { 1962, "Freezers", "10003698" },
                    { 1963, "Ice Makers", "10001938" },
                    { 1965, "Refrigerating/Freezing Appliances Replacement Parts/Accessories", "10001942" },
                    { 2046, "Pizza Makers", "10001985" },
                    { 1992, "Cookie Guns (Powered)", "10005358" },
                    { 1994, "Food/Beverage Appliances Variety Packs", "10002022" },
                    { 2022, "Air Controlling Appliances – Multifunction – Portable", "10005335" },
                    { 2023, "Air Coolers – Portable", "10005334" },
                    { 2024, "Air Dehumidifier - Portable (Non-Powered)", "10006798" },
                    { 2025, "Air Dehumidifiers – Portable (Powered)", "10005332" },
                    { 2026, "Air Heaters – Portable", "10003992" },
                    { 2027, "Air Humidifiers – Portable", "10005331" },
                    { 2028, "Air Ionisers – Portable", "10005333" },
                    { 2029, "Air Purifiers – Portable", "10005336" },
                    { 2030, "Fans – Portable", "10005337" },
                    { 2031, "Portable Air Control Appliances Replacement Parts/Accessories", "10005697" },
                    { 2032, "Breadmakers", "10001983" },
                    { 2033, "Cake / Pie Maker", "10006740" },
                    { 2034, "Cooking Appliances Variety Packs", "10001991" },
                    { 2035, "Deep Fryers", "10001981" },
                    { 2036, "Egg Cookers", "10001980" },
                    { 2037, "Fondues (Powered)", "10001986" },
                    { 2038, "Grills (Powered)", "10001969" },
                    { 2039, "Hot Dog Rollers", "10005704" },
                    { 2040, "Hot Stones (Powered)", "10001990" },
                    { 2041, "Mexican Diners (Powered)", "10001988" },
                    { 2042, "Multi-cookers", "10001978" },
                    { 2043, "Paella Makers", "10001989" },
                    { 2044, "Pancake/Doughnut Makers", "10001971" },
                    { 2021, "Air Conditioners – Portable", "10005317" },
                    { 1993, "Dehydrators (Powered)", "10002018" },
                    { 2020, "Laundry Care Appliances Replacement Parts/Accessories", "10002027" },
                    { 2018, "Ironing Boards (Powered)", "10002024" },
                    { 1995, "Food/Beverage Preparation Appliances Replacement Parts/Accessories", "10002021" },
                    { 1996, "Frozen Drinks Makers/Ice Shavers (Powered)", "10005689" },
                    { 1997, "Graters (Powered)", "10002005" },
                    { 1998, "Hot Beverage Makers", "10002011" },
                    { 1999, "Ice Cream Makers (Powered)", "10002013" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2000, "Ice Crushers/Ice Cube Makers (Powered)", "10005357" },
                    { 2001, "Juicers (Powered)", "10002007" },
                    { 2002, "Kettles (Powered)", "10002012" },
                    { 2003, "Kitchen Blending Appliances", "10006739" },
                    { 2004, "Kitchen Chopping Appliances", "10006737" },
                    { 2005, "Kitchen Combination Mixing/Blending/Chopping Appliances", "10006735" },
                    { 2006, "Kitchen Mixing Appliances", "10006738" },
                    { 2007, "Kitchen Scales (Powered)", "10005695" },
                    { 2008, "Kitchen Slicing Appliances", "10006736" },
                    { 2009, "Knife Sharpeners (Powered)", "10002002" },
                    { 2010, "Knives (Powered)", "10001998" },
                    { 2011, "Meat Grinders/Mincers (Powered)", "10002004" },
                    { 2012, "Party Drink Fountains (Powered)", "10005868" },
                    { 2013, "Vacuum Sealers (Powered)", "10002003" },
                    { 2014, "Wine/Bottle Openers (Powered)", "10005691" },
                    { 2015, "Yogurt Makers", "10002014" },
                    { 2016, "Clothes Irons (Powered)", "10002023" },
                    { 2017, "Clothes Presses", "10002025" },
                    { 2019, "Ironing Steam Station", "10005830" },
                    { 2584, "Hammocks", "10003250" },
                    { 2585, "Lawn/Garden Furnishings Other", "10003253" },
                    { 2586, "Lawn/Garden Furnishings Replacement Parts/Accessories", "10003251" },
                    { 3153, "Paper Shredders (Powered)", "10005119" },
                    { 3154, "Stationery Cutters/Trimmers Other", "10001306" },
                    { 3155, "Stationery Scissors", "10005371" },
                    { 3156, "Business Forms/Paper – Pre-printed", "10001305" },
                    { 3157, "Exercise Books", "10005893" },
                    { 3158, "Labels/Coupons/Tickets", "10001313" },
                    { 3159, "Paper/Card – Unprinted", "10001304" },
                    { 3160, "Stationery Paper/Card/Film Other", "10005120" },
                    { 3161, "Transparencies/Acetates", "10001314" },
                    { 3162, "Book Covers", "10005125" },
                    { 3152, "Paper Shredders (Non Powered)", "10001309" },
                    { 3163, "Cash/Money Boxes", "10001316" },
                    { 3165, "Stationery Files/Folders/Wallets", "10001318" },
                    { 3166, "Stationery Item Storage/Desk Accessories", "10001320" },
                    { 3167, "Stationery Storage/Filing – Replacement Parts/Accessories", "10001322" },
                    { 3168, "Stationery Storage/Filing Other", "10001321" },
                    { 3169, "Stationery Storage/Filing Variety Packs", "10001323" },
                    { 3170, "Stationery/Office Machinery Variety Packs", "10001325" },
                    { 3171, "Correction Aids", "10001226" },
                    { 3172, "Desktop Mats", "10005206" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 3173, "Ink", "10001225" },
                    { 3174, "Measuring/Geometrical Equipment (Stationery)", "10001231" },
                    { 3164, "Pencil/Pen Cases", "10006897" },
                    { 3151, "Paper Guillotines/Trimmers", "10001302" },
                    { 3150, "Hole Paper Punches (Powered)", "10001312" },
                    { 3149, "Hole Paper Punches (Non Powered)", "10001311" },
                    { 3126, "Postal Weighing Scales (Non Powered)", "10001267" },
                    { 3127, "Postal/Packaging Accessories", "10001269" },
                    { 3128, "Postal/Packaging Equipment/Aids/Accessories Other", "10001270" },
                    { 3129, "Stamping Equipment (Non Powered)", "10001241" },
                    { 3130, "Flip-chart Stands", "10001275" },
                    { 3131, "Overhead Projectors", "10005445" },
                    { 3132, "Pointers (Non Powered)", "10001276" },
                    { 3133, "Pointers (Powered)", "10001277" },
                    { 3134, "Presentation Boards (Non Powered)", "10001278" },
                    { 3135, "Presentation Boards (Powered)", "10006406" },
                    { 3136, "Presentation Equipment Accessories", "10001281" },
                    { 3137, "Presentation Equipment Other", "10001280" },
                    { 3138, "Projection Tables", "10005766" },
                    { 3139, "Adhesive Paste/Glue Removers", "10005444" },
                    { 3140, "Binding Accessories", "10001286" },
                    { 3141, "Binding Machines (Non Powered)", "10001287" },
                    { 3142, "Binding Machines (Powered)", "10001288" },
                    { 3143, "Stationery Adhesive Tapes", "10005126" },
                    { 3144, "Stationery Adhesives/Binders/Fasteners Other", "10001295" },
                    { 3145, "Stationery Fasteners", "10001289" },
                    { 3146, "Stationery Glues", "10001292" },
                    { 3147, "Stationery Staple Removers", "10001298" },
                    { 3148, "Stationery Staplers (Powered)", "10001300" },
                    { 3175, "Pencil Sharpeners (Non Powered)", "10001232" },
                    { 3176, "Pencil Sharpeners (Powered)", "10001233" },
                    { 3177, "Pencils (Stationery)", "10001234" },
                    { 3178, "Pens (Stationery)", "10001235" },
                    { 3206, "Audio Periodicals", "10004104" },
                    { 3207, "Digital Periodical Content", "10000927" },
                    { 3208, "Periodicals Variety Packs", "10004108" },
                    { 3209, "Printed Periodicals", "10000928" },
                    { 3210, "Textual/Printed/Reference Materials Variety Packs", "10002103" },
                    { 3211, "Tool Belts/Holsters/Pouches", "10003678" },
                    { 3212, "Tool Boxes/Cases", "10003676" },
                    { 3213, "Tool Cabinets", "10003674" },
                    { 3214, "Tool Carrybags/Wallets", "10003677" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 3215, "Tool Carts", "10003578" },
                    { 3216, "Tool Storage Other", "10005102" },
                    { 3217, "Roller Stands", "10003572" },
                    { 3218, "Router Tables", "10005806" },
                    { 3219, "Saw Horses/Trestles", "10003470" },
                    { 3220, "Work Benches", "10003468" },
                    { 3221, "Workshop Aids Other", "10005101" },
                    { 3222, "Workshop Cloths/Rags", "10005723" },
                    { 3223, "Awls", "10003490" },
                    { 3224, "Awls/Punches/Nailsets Variety Packs", "10003778" },
                    { 3225, "Punches", "10003487" },
                    { 3226, "Hand Trucks/Dollies", "10003497" },
                    { 3227, "Ladders", "10003821" },
                    { 3228, "Platforms/Scaffolding", "10003473" },
                    { 3205, "Printed Maps", "10004105" },
                    { 3125, "Postal Tubes/Boxes", "10001266" },
                    { 3204, "Electronic Maps", "10004106" },
                    { 3202, "Digital eBook Content", "10000925" },
                    { 3179, "Stencils (Stationery)", "10001236" },
                    { 3180, "Writing Implements – Replacement Parts", "10001229" },
                    { 3181, "Writing/Design Implements/Aids Other", "10001228" },
                    { 3182, "Stationery/Office Machinery/Occasion Supplies Variety Packs", "10003771" },
                    { 3183, "Storage Barrels/Kegs (Empty)", "10005846" },
                    { 3184, "Storage Drums (Empty)", "10005847" },
                    { 3185, "Portable Storage Cylinders (Empty)", "10005852" },
                    { 3186, "Storage Bottles (Empty)", "10005851" },
                    { 3187, "Pallet Converters/Frames", "10005857" },
                    { 3188, "Pallets", "10005854" },
                    { 3189, "Racks", "10005858" },
                    { 3190, "Slip Sheets", "10005856" },
                    { 3191, "Transport Dollies", "10005855" },
                    { 3192, "Storage/Haulage Boxes (Empty)", "10005848" },
                    { 3193, "Storage/Haulage Crates (Empty)", "10005849" },
                    { 3194, "Storage/Haulage Trays (Empty)", "10005850" },
                    { 3195, "Air Freight Containers (Empty)", "10005860" },
                    { 3196, "Flexible Bulk Containers (Empty)", "10005861" },
                    { 3197, "Ocean Intermodal Freight Containers (Empty)", "10005859" },
                    { 3198, "Rigid Intermediate Bulk Containers (Empty)", "10005862" },
                    { 3199, "Storage/Haulage Tanks (Empty)", "10005853" },
                    { 3200, "Audio Books", "10004103" },
                    { 3201, "Books Variety Packs", "10004107" },
                    { 3203, "Printed Books/Compositions", "10000926" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 3124, "Postal Packaging/Wrap", "10001273" },
                    { 3123, "Postal Labelling Machines", "10001245" },
                    { 3122, "Postage Stamps", "10006849" },
                    { 3045, "Sports Bats/Sticks/Clubs", "10001780" },
                    { 3046, "Sports Bats/Sticks/Clubs Other", "10001787" },
                    { 3047, "Pumps (Non Powered)", "10005702" },
                    { 3048, "Sports Equipment Accessories Other", "10001903" },
                    { 3049, "Sports Equipment Bags/Cases/Covers", "10001892" },
                    { 3050, "Sports Equipment Storage Racks/Holders", "10001898" },
                    { 3051, "Sports Goals/Nets Accessories", "10001894" },
                    { 3052, "Sports Goals/Nets/Enclosures", "10001893" },
                    { 3053, "Sports Marking Equipment", "10001896" },
                    { 3054, "Sports Mats/Carpets", "10001900" },
                    { 3055, "Sports Scoring Equipment (Non Powered)", "10001899" },
                    { 3056, "Sports Scoring Equipment (Powered)", "10004111" },
                    { 3057, "Sports Target Pins/Skittles/Stumps", "10001897" },
                    { 3058, "Sports Equipment Variety Packs", "10003688" },
                    { 3059, "Sports Personal Protective Equipment Variety Packs", "10001911" },
                    { 3060, "Sports Protective Body Padding/Guards", "10001907" },
                    { 3061, "Sports Protective Goggles/Eye Masks", "10001905" },
                    { 3062, "Sports Protective Mouth Guards", "10001904" },
                    { 3063, "Sports Protective Support Belts", "10001909" },
                    { 3064, "Sports Tables", "10001855" },
                    { 3065, "Sports Tables Other", "10001859" },
                    { 3066, "Boards/Skis (Water Sports)", "10001844" },
                    { 3067, "Boards/Skis (Water Sports) – Replacement Parts/Accessories", "10001845" },
                    { 3044, "Sports Balls/Pucks/Shuttlecocks/Frisbees/Boomerangs Other", "10001775" },
                    { 3068, "Diving Equipment", "10001848" },
                    { 3043, "Sports Balls", "10001768" },
                    { 3041, "Pucks", "10001769" },
                    { 3018, "Personal Fitness Sports Equipment Other", "10001825" },
                    { 3019, "Sports Exercise Monitors", "10001822" },
                    { 3020, "Racquet Sports – Replacement Parts/Accessories", "10001778" },
                    { 3021, "Racquet Sports Equipment Other", "10004097" },
                    { 3022, "Racquets", "10001776" },
                    { 3023, "Scooter/Skateboard Sports Equipment Other", "10001843" },
                    { 3024, "Scooters/Skateboards/Hoverboards (Powered)", "10005814" },
                    { 3025, "Skateboarding Sports Equipment – Replacement Parts/Accessories", "10001841" },
                    { 3026, "Skateboards (Non Powered)", "10001840" },
                    { 3027, "Curling Stones", "10001794" },
                    { 3028, "Skis/Ski Boards/Snow Boards", "10001792" },
                    { 3029, "Sleds", "10001790" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 3030, "Snow/Ice Sports Equipment – Replacement Parts/Accessories", "10001795" },
                    { 3031, "Snow/Ice Sports Equipment Other", "10001797" },
                    { 3032, "Airguns", "10001873" },
                    { 3033, "Firearms Ammunition", "10001874" },
                    { 3034, "Handguns/Pistols", "10001870" },
                    { 3035, "Rifles", "10001871" },
                    { 3036, "Shotguns", "10001872" },
                    { 3037, "Sporting Firearms – Replacement Parts/Accessories", "10001877" },
                    { 3038, "Sporting Firearms Equipment Other", "10001879" },
                    { 3039, "Boomerangs", "10001772" },
                    { 3040, "Frisbees", "10001771" },
                    { 3042, "Shuttlecocks", "10001770" },
                    { 3229, "Pulley Puller (Hand)", "10006778" },
                    { 3069, "Swimming Training Aids", "10001847" },
                    { 3071, "Swimming/Surfing/Diving Sports Equipment Other", "10001854" },
                    { 3099, "Party Crackers", "10001220" },
                    { 3100, "Party Horns/Blowers", "10005436" },
                    { 3101, "Pinatas", "10001223" },
                    { 3102, "Calculators/Currency Converters (Powered)", "10001242" },
                    { 3103, "Cash/Money Registers (Powered)", "10001243" },
                    { 3104, "Laminating Machine Consumables", "10001246" },
                    { 3105, "Laminating Machines (Powered)", "10001247" },
                    { 3106, "Multifunctional Devices", "10005229" },
                    { 3107, "Office Machinery Other", "10001248" },
                    { 3108, "Photocopier Consumables", "10001251" },
                    { 3109, "Photocopiers", "10001252" },
                    { 3110, "Typewriter Consumables", "10005676" },
                    { 3111, "Typewriters (Non Powered)", "10001253" },
                    { 3112, "Typewriters (Powered)", "10001254" },
                    { 3113, "Calendars/Planners", "10001255" },
                    { 3114, "Contact Information Books/Pads", "10001256" },
                    { 3115, "Organizational Planning Stationery – Replacement Parts/Accessories", "10001258" },
                    { 3116, "Organizational Planning Stationery Other", "10001257" },
                    { 3117, "Personal Organizers/Diaries (Non Powered)", "10001260" },
                    { 3118, "Sticky Notes/Paper Cubes", "10005118" },
                    { 3119, "Envelopes/Mailers", "10001261" },
                    { 3120, "Franking Machines", "10001262" },
                    { 3121, "Letter Openers (Non Powered)", "10001264" },
                    { 3098, "Occasion Supplies Other", "10001217" },
                    { 3070, "Swimming/Surfing/Diving Sports Equipment – Replacement Parts/Accessories", "10001852" },
                    { 3097, "Confetti", "10001215" },
                    { 3095, "Invitation Pads/Notelets", "10001212" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 3072, "Arrows", "10001863" },
                    { 3073, "Bows", "10001862" },
                    { 3074, "Darts", "10001860" },
                    { 3075, "Target Sports Equipment – Replacement Parts/Accessories", "10001867" },
                    { 3076, "Target Sports Equipment Other", "10001869" },
                    { 3077, "Targets (Non Powered)", "10001866" },
                    { 3078, "Targets (Powered)", "10001865" },
                    { 3079, "Jumping Sports Equipment", "10001764" },
                    { 3080, "Running Sports Equipment", "10001763" },
                    { 3081, "Throwing Sports Equipment", "10001762" },
                    { 3082, "Track/Field Sports Equipment Other", "10001767" },
                    { 3083, "Trekking/Mountaineering Sports Equipment", "10001798" },
                    { 3084, "Trekking/Mountaineering Sports Equipment Other", "10001805" },
                    { 3085, "Watercraft", "10001887" },
                    { 3086, "Watercraft – Replacement Parts/Accessories", "10001889" },
                    { 3087, "Watercraft Sports Equipment Other (Non Powered)", "10001891" },
                    { 3088, "Gift Wrap", "10001201" },
                    { 3089, "Gift Wrap Accessories", "10001203" },
                    { 3090, "Gift Wrap/Accessories Other", "10001202" },
                    { 3091, "Greeting Cards/Gift Wrap/Occasion Supplies Variety Packs", "10001205" },
                    { 3092, "Greeting Card Display Holders", "10001206" },
                    { 3093, "Greeting Cards/Invitations", "10001209" },
                    { 3094, "Greeting Cards/Invitations Other", "10001207" },
                    { 3096, "Postcards", "10001213" },
                    { 3230, "Suction Lifters", "10003498" },
                    { 3231, "Wheelbarrows – Non Powered", "10003496" },
                    { 3232, "Chisels", "10003488" },
                    { 3368, "Shapers – Stationary", "10003746" },
                    { 3369, "Spindle Sanders", "10003610" },
                    { 3370, "Surface Planers – Stationary", "10003729" },
                    { 3371, "Table Saws – Stationary", "10003601" },
                    { 3372, "Wet Saws/Tile/Glass Cutters", "10003596" },
                    { 3373, "Lottery and Scratch Cards", "10006755" },
                    { 3374, "Board Games (Non Powered)", "10005133" },
                    { 3375, "Board Games (Powered)", "10005134" },
                    { 3376, "Board Games/Cards/Puzzles – Accessories/Replacement Parts", "10005135" },
                    { 3377, "Board Games/Cards/Puzzles Other", "10005136" },
                    { 3378, "Card Games (Non Powered)", "10005138" },
                    { 3379, "Card Games (Powered)", "10005139" },
                    { 3380, "Puzzles (Non Powered)", "10005140" },
                    { 3381, "Puzzles (Powered)", "10005141" },
                    { 3382, "Baby/Infant Stimulation Toys (Non Powered)", "10005153" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 3383, "Baby/Infant Stimulation Toys (Powered)", "10005154" },
                    { 3384, "Bath/Pool Water Toys", "10005155" },
                    { 3385, "Communication Toys (Non Powered)", "10005156" },
                    { 3386, "Communication Toys (Powered)", "10005157" },
                    { 3387, "Developmental/Educational Toys Other", "10005159" },
                    { 3388, "Push/Pull-along Toys (Non Powered)", "10005161" },
                    { 3389, "Push/Pull-along Toys (Powered)", "10005162" },
                    { 3390, "Scientific Toys (Non Powered)", "10005163" },
                    { 3367, "Scroll Saws – Stationary", "10003602" },
                    { 3391, "Scientific Toys (Powered)", "10005164" },
                    { 3366, "Radial Arm Saws", "10003603" },
                    { 3364, "Lathes – Stationary (Powered)", "10003605" },
                    { 3341, "Screw Guns", "10003657" },
                    { 3342, "Screwdrivers/Rotary Tools", "10003654" },
                    { 3343, "Soldering/Brazing Irons", "10003649" },
                    { 3344, "Staplers (Powered)", "10003665" },
                    { 3345, "Straight/Die Grinders", "10003647" },
                    { 3346, "Stud Finders/Detectors/Sensors", "10005869" },
                    { 3347, "Surface Grinders", "10003648" },
                    { 3348, "Surface/Thickness Planers – Portable", "10003615" },
                    { 3349, "Table Saws – Portable", "10003627" },
                    { 3350, "Tappers", "10003639" },
                    { 3351, "Wall/Ceiling Covering Tools – Powered", "10003884" },
                    { 3352, "Welding/Blow Torches", "10003744" },
                    { 3353, "Hoists/Winches", "10003679" },
                    { 3354, "Power Tools – Lifting/Handling Equipment Other", "10003749" },
                    { 3355, "Pulley Puller (Powered)", "10006779" },
                    { 3356, "Air Compressors – Stationary", "10005230" },
                    { 3357, "Band Saws – Stationary", "10003597" },
                    { 3358, "Belt Sanders – Stationary", "10003668" },
                    { 3359, "Bench Grinders", "10003598" },
                    { 3360, "Bench Jointers", "10003604" },
                    { 3361, "Disc Sanders", "10003609" },
                    { 3362, "Drill Presses/Mortisers", "10003613" },
                    { 3363, "Jointer Planers – Stationary", "10003730" },
                    { 3365, "Power Tools – Stationary – Replacement Parts/Accessories", "10003608" },
                    { 3340, "Routers", "10003737" },
                    { 3392, "Spinning Tops/Yo-Yos", "10005165" },
                    { 3394, "Toy Building Blocks (Powered)", "10005167" },
                    { 3422, "Outdoor Play Structures", "10005182" },
                    { 3423, "Musical Toys (Non Powered)", "10005177" },
                    { 3424, "Musical Toys (Powered)", "10005178" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 3425, "Musical Toys Other", "10005179" },
                    { 3426, "Role Play – Housekeeping/Gardening/DIY Toys", "10005684" },
                    { 3427, "Role Play – Kitchen Toys", "10005250" },
                    { 3428, "Role Play – Shopping/Office/Business Toys", "10005685" },
                    { 3429, "Table Games (Non Powered)", "10005183" },
                    { 3430, "Table Games (Powered)", "10005184" },
                    { 3431, "Table Games Other", "10005185" },
                    { 3432, "Car/Train Set – Replacement Parts/Accessories", "10005192" },
                    { 3433, "Car/Train Sets (Non Powered)", "10005190" },
                    { 3434, "Car/Train Sets (Powered)", "10005191" },
                    { 3435, "Toy Vehicles – Non-ride (Non Powered)", "10005193" },
                    { 3436, "Toy Vehicles – Non-ride (Powered)", "10005194" },
                    { 3437, "Toy Vehicles – Non-ride Other", "10005195" },
                    { 3438, "Toys – Ride-on (Non Powered)", "10005187" },
                    { 3439, "Toys – Ride-on (Powered)", "10005188" },
                    { 3440, "Toys – Ride-on Accessories", "10005441" },
                    { 3441, "Practical Jokes", "10005443" },
                    { 3442, "Toys/Games Variety Packs", "10005186" },
<<<<<<< HEAD
                    { 3443, "General", "1000000" },
=======
                    { 3443, "General", null },
>>>>>>> c3bfcb876cb8446ba1552801bb5433187e2c3bfa
                    { 3444, "Medical Devices", "10005844" },
                    { 3421, "Outdoor Games/Play Structures Other", "10005180" },
                    { 3393, "Toy Building Blocks (Non Powered)", "10005166" },
                    { 3420, "Indoor/Outdoor Games", "10005181" },
                    { 3418, "Fancy Dress Costumes", "10005172" },
                    { 3395, "Toy Computer Accessories", "10005712" },
                    { 3396, "Toy Computers", "10005158" },
                    { 3397, "Toy Drawing Boards/Accessories", "10005442" },
                    { 3398, "Toy Model Construction (Non Powered)", "10005168" },
                    { 3399, "Toy Model Construction (Powered)", "10005169" },
                    { 3400, "Viewing Toys (Non Powered)", "10005170" },
                    { 3401, "Viewing Toys (Powered)", "10005171" },
                    { 3402, "Action Figures (Non Powered)", "10006395" },
                    { 3403, "Action Figures (Powered)", "10006396" },
                    { 3404, "Dolls/Puppets/Soft Toys Other", "10005144" },
                    { 3405, "Dolls/Soft Toys (Non Powered)", "10005142" },
                    { 3406, "Dolls/Soft Toys (Powered)", "10005143" },
                    { 3407, "Puppets", "10005145" },
                    { 3408, "Action Figure Accessories", "10006397" },
                    { 3409, "Dolls Beauty/Cosmetic Accessories", "10005146" },
                    { 3410, "Dolls Buildings/Settings", "10005147" },
                    { 3411, "Dolls Clothing", "10005148" },
                    { 3412, "Dolls Furniture", "10005149" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 3413, "Dolls/Puppets/Soft Toys Accessories Other", "10005150" },
                    { 3414, "Puppet Theatres", "10005152" },
                    { 3415, "Styling Dolls Heads (Non Powered)", "10005439" },
                    { 3416, "Fancy Dress Accessories (Non Powered)", "10005175" },
                    { 3417, "Fancy Dress Accessories (Powered)", "10005176" },
                    { 3419, "Fancy Dress Costumes/Accessories Other", "10005173" },
                    { 3017, "Personal Fitness Sports Equipment – Replacement Parts/Accessories", "10001823" },
                    { 3339, "Rotary Saws", "10003641" },
                    { 3337, "Reciprocating Saws", "10003629" },
                    { 3260, "Measuring Wheels", "10003461" },
                    { 3261, "Micrometers", "10003459" },
                    { 3262, "Moisture Meter (Soil)", "10006776" },
                    { 3263, "Plumb Bobs", "10003466" },
                    { 3264, "Rulers (DIY)", "10003455" },
                    { 3265, "Squares (DIY)", "10003464" },
                    { 3266, "Tape Measures (DIY)", "10003458" },
                    { 3267, "Thermal Leak Detector", "10006777" },
                    { 3268, "Hammer Tacker – Non Powered", "10003504" },
                    { 3269, "Nailing/Stapling/Fixing Tool Replacement Pars/Accessories", "10003507" },
                    { 3270, "Staple/Nail Gun – Non Powered", "10003502" },
                    { 3271, "Flaring Tools", "10003549" },
                    { 3272, "Pipe Threaders – Non Powered", "10003642" },
                    { 3273, "Tubing Benders", "10003548" },
                    { 3274, "Files", "10003533" },
                    { 3275, "Planes", "10003544" },
                    { 3276, "Planes/Shapers/Files/Rasps Variety Packs", "10003807" },
                    { 3277, "Surface Forming Tool Consumables", "10003546" },
                    { 3278, "Bolt/Chain Cutters", "10003481" },
                    { 3279, "Forceps (DIY)", "10006781" },
                    { 3280, "Pliers/Pincers/Grabbers", "10003532" },
                    { 3281, "Snips/Shears/Nibblers – Sheet Metal (Non Powered)", "10003486" },
                    { 3282, "Fluid Guns", "10006782" },
                    { 3259, "Marking Chalks/String Lines", "10005707" },
                    { 3283, "Blades – Saw – Non Powered", "10003800" },
                    { 3258, "Dividers/Compass (DIY)", "10003454" },
                    { 3256, "Masonry Trowels", "10003594" },
                    { 3233, "Chisels/Gouges Variety Packs", "10003787" },
                    { 3234, "Crowbars/Pry Bars", "10003499" },
                    { 3235, "Nut Splitters", "10003563" },
                    { 3236, "Drilling Replacement Parts/Accessories", "10003542" },
                    { 3237, "Drills – Non Powered", "10003541" },
                    { 3238, "Paint Application Accessories", "10005656" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 3239, "Paint Applicators – Non Powered", "10005654" },
                    { 3240, "Painting Replacement Parts", "10002481" },
                    { 3241, "Plaster Hawks", "10003573" },
                    { 3242, "Wall/Ceiling Covering Tools – Non Powered", "10005672" },
                    { 3243, "Funnels (DIY)", "10005714" },
                    { 3244, "Gas Torches", "10006783" },
                    { 3245, "Grinders (Non Powered)", "10003538" },
                    { 3246, "Scrapers", "10003543" },
                    { 3247, "Anvils (DIY)", "10003552" },
                    { 3248, "Hammers (DIY)", "10003500" },
                    { 3249, "Hammers/Mallets/Hatches Replacement Parts/Accessories", "10003501" },
                    { 3250, "Hatchets (DIY)", "10003789" },
                    { 3251, "Mallets (DIY)", "10003788" },
                    { 3252, "Knife Blades – Non Powered (Hobby/Utility)", "10003824" },
                    { 3253, "Knives – Non Powered (Hobby/Utility)", "10003492" },
                    { 3254, "Knives – Non Powered Replacement Parts/Accessories", "10003823" },
                    { 3255, "Cutters – Glass (Non Powered)", "10003485" },
                    { 3257, "Bevel Gauges", "10005716" },
                    { 3338, "Rotary Hammers", "10003660" },
                    { 3284, "Saws – Hand – Replacement Parts/Accessories", "10003801" },
                    { 3286, "Screwdriver Sets", "10003530" },
                    { 3314, "Drain Augers (Powered)", "10003741" },
                    { 3315, "Drill/Drivers (Powered)", "10003653" },
                    { 3316, "Drills – Combination (Powered)", "10003658" },
                    { 3317, "Finishing Sanders", "10003669" },
                    { 3318, "Foam Cutters – Powered", "10003638" },
                    { 3319, "Generators", "10005211" },
                    { 3320, "Glue Guns – Powered", "10005213" },
                    { 3321, "Grease Guns (Powered)", "10003663" },
                    { 3322, "Hammer Drills", "10003659" },
                    { 3323, "Heat Guns", "10003662" },
                    { 3324, "Impact Drivers", "10003655" },
                    { 3325, "Impact Wrenches", "10003656" },
                    { 3326, "Jigsaws – Powered", "10003631" },
                    { 3327, "Jointer Planers – Portable", "10003616" },
                    { 3328, "Laminate Trimmers", "10003626" },
                    { 3329, "Laser Levels", "10003620" },
                    { 3330, "Metal Detectors", "10006277" },
                    { 3331, "Mitre Saws – Portable", "10003738" },
                    { 3332, "Nail Guns (Powered)", "10003666" },
                    { 3333, "Nibblers/Shears – Metal (Powered)", "10003632" },
                    { 3334, "Paint Applicators – Powered", "10005653" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 3335, "Pipe Cutters (Powered)", "10003640" },
                    { 3336, "Power Tools – Hand-held Portable Other", "10003750" },
                    { 3313, "Distance/Linear Measurers (Powered)", "10003618" },
                    { 3285, "Saws – Non Powered", "10003799" },
                    { 3312, "Disc Sanders – Portable", "10005248" },
                    { 3310, "Cut-off Tools", "10003645" },
                    { 3287, "Screwdrivers – Non Powered", "10003528" },
                    { 3288, "Screwdrivers Other", "10003825" },
                    { 3289, "Dies (Non Powered)", "10003550" },
                    { 3290, "Taps (Non Powered)", "10003808" },
                    { 3291, "Tools/Equipment – Hand Variety Packs", "10005645" },
                    { 3292, "Clamps", "10003535" },
                    { 3293, "Vises", "10003536" },
                    { 3294, "Vises/Clamps Replacement Parts/Accessories", "10003537" },
                    { 3295, "Socket Sets", "10005252" },
                    { 3296, "Wrenches/Spanners", "10003508" },
                    { 3297, "Wrenches/Spanners Sets", "10003796" },
                    { 3298, "Wrenches/Spanners/Keys Variety Packs", "10003795" },
                    { 3299, "Air Compressors – Portable", "10003555" },
                    { 3300, "Angle Grinders", "10003644" },
                    { 3301, "Angle Measures (Powered)", "10003619" },
                    { 3302, "Arc Welders", "10003651" },
                    { 3303, "Band Saws – Portable", "10005231" },
                    { 3304, "Belt Sanders – Portable", "10003742" },
                    { 3305, "Biscuit Joiners", "10005718" },
                    { 3306, "Caulking Guns (Powered)", "10003664" },
                    { 3307, "Cement/Mortar Mixing Machines", "10005214" },
                    { 3308, "Chisels (Powered)", "10003643" },
                    { 3309, "Circular Saws", "10005223" },
                    { 3311, "Detail Sanders", "10003672" },
                    { 1724, "Seedlings - Ready to Eat", "10006259" },
                    { 3016, "Gym Accessories", "10001819" },
                    { 3014, "Exercise Machines (Powered)", "10001814" },
                    { 2722, "Vertebrates Other", "10005476" },
                    { 2723, "Lubricants Variety Packs", "10005356" },
                    { 2724, "Lubricating Greases", "10005268" },
                    { 2725, "Lubricating Oils/Fluids", "10005267" },
                    { 2726, "Lubricating Products Variety Packs", "10005270" },
                    { 2727, "Anti-corrosives", "10005273" },
                    { 2728, "Antifreeze/Coolants", "10005272" },
                    { 2729, "Anti-spatter Products", "10005321" },
                    { 2730, "Protective Compounds Variety Packs", "10005275" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2731, "Drain Pans", "10005277" },
                    { 2721, "Swine (Pigs)", "10005464" },
                    { 2732, "Lubricant Containers/Dispensers (Empty)", "10005276" },
                    { 2734, "Lubricating Oil/Fluid Pumps (Non Powered)", "10005281" },
                    { 2735, "Lubricating Oil/Fluid Pumps (Powered)", "10005282" },
                    { 2736, "Brasswind Musical Instrument Accessories (Non Powered)", "10004116" },
                    { 2737, "Keyboard/Piano Accessories (Powered)", "10004117" },
                    { 2738, "Metronomes/Tuners (Non Powered)", "10004125" },
                    { 2739, "Metronomes/Tuners (Powered)", "10004123" },
                    { 2740, "Musical Instrument Accessories Other", "10004128" },
                    { 2741, "Musical Instrument Cases/Bags/Covers", "10004121" },
                    { 2742, "Musical Instrument Cleaning Products", "10004122" },
                    { 2743, "Musical Instrument Holders/Stands/Lyres", "10004124" },
                    { 2733, "Lubricants/Protective Compounds Storage Variety Packs", "10005280" },
                    { 2720, "Rodents", "10005455" },
                    { 2719, "Reptiles", "10005466" },
                    { 2718, "Primates", "10005459" },
                    { 2695, "Sunshine Recording Equipment – Powered", "10003435" },
                    { 2696, "Thermometers – Garden – Non Powered", "10003440" },
                    { 2697, "Thermometers – Garden – Powered", "10005319" },
                    { 2698, "Wind Socks/Weather Vanes", "10003446" },
                    { 2699, "Annelids (Worms)", "10005448" },
                    { 2700, "Arachnids (Spiders/Scorpions)", "10005447" },
                    { 2701, "Coral/Sea Anemone", "10005454" },
                    { 2702, "Insects", "10005446" },
                    { 2703, "Invertebrates Other", "10005475" },
                    { 2704, "Molluscs", "10005449" },
                    { 2705, "Sea Stars/Sea Urchins", "10005452" },
                    { 2706, "Amphibians", "10005458" },
                    { 2707, "Birds", "10005457" },
                    { 2708, "Bovine (Cattle)", "10005461" },
                    { 2709, "Canine (Dogs)", "10005625" },
                    { 2710, "Caprine (Goats)", "10005462" },
                    { 2711, "Cetaceans (Whales/Dolphins/Porpoises)", "10005469" },
                    { 2712, "Equine (Horses/Donkeys)", "10005463" },
                    { 2713, "Feline (Cats)", "10005460" },
                    { 2714, "Fishes", "10005456" },
                    { 2715, "Lagomorphs (Hares/Rabbits)", "10005468" },
                    { 2716, "Marsupials", "10005467" },
                    { 2717, "Ovine (Sheep)", "10005465" },
                    { 2744, "Percussion Musical Instrument Accessories (Non Powered)", "10004118" },
                    { 2745, "String Musical Instrument Accessories (Non Powered)", "10004119" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2746, "Woodwind Musical Instrument Accessories (Non Powered)", "10004120" },
                    { 2747, "Brasswind Musical Instruments (Non Powered)", "10000933" },
                    { 2775, "Body Bags/Waist Bags", "10001094" },
                    { 2776, "Briefcases", "10001095" },
                    { 2777, "Handbags/Shoulder Bags", "10001096" },
                    { 2778, "Key Rings", "10005756" },
                    { 2779, "Luggage/Personal Bags/Umbrellas Accessories", "10001097" },
                    { 2780, "Luggage/Suitcases/Garment Carriers", "10001099" },
                    { 2781, "Personal Bags/Luggage/Umbrellas Other", "10001390" },
                    { 2782, "Personal Bags/Luggage/Umbrellas Variety Packs", "10001391" },
                    { 2783, "Personal Carrier Bags (Disposable)", "10005817" },
                    { 2784, "Rucksacks/Backpacks/Holdalls", "10001100" },
                    { 2785, "Shopping Trolley Bags", "10001101" },
                    { 2786, "Toiletry Bags/Vanity Cases", "10005200" },
                    { 2787, "Umbrellas – Personal", "10001102" },
                    { 2788, "Wallets/Purses/Travel Document Holders", "10001103" },
                    { 2789, "Watch Accessories/Replacement Parts", "10001104" },
                    { 2790, "Watches", "10001105" },
                    { 2791, "Watches Other", "10001392" },
                    { 2792, "Aquarium Aids/Accessories (Non Powered)", "10000516" },
                    { 2793, "Aquarium Aids/Accessories (Powered)", "10000656" },
                    { 2794, "Pet Accessories Other", "10000736" },
                    { 2795, "Pet Accessory Variety Packs", "10000659" },
                    { 2796, "Pet Attire", "10000643" },
                    { 2797, "Pet Food/Drink Dispenser (Powered)", "10000660" },
                    { 2774, "Personal Accessories Variety Packs", "10001389" },
                    { 2694, "Rain Gauges – Powered", "10005320" },
                    { 2773, "Tiaras", "10001093" },
                    { 2771, "Pendants", "10001091" },
                    { 2748, "Keyboards/Pianos (Non Powered)", "10000934" },
                    { 2749, "Musical Instruments Other (Non Powered)", "10001375" },
                    { 2750, "Percussion Musical Instruments (Non Powered)", "10000935" },
                    { 2751, "String Musical Instruments (Non Powered)", "10000936" },
                    { 2752, "Woodwind Musical Instruments (Non Powered)", "10000937" },
                    { 2753, "Brasswind Musical Instruments (Powered)", "10000938" },
                    { 2754, "Keyboards/Pianos (Powered)", "10000940" },
                    { 2755, "Musical Instrument Aids (Powered)", "10000939" },
                    { 2756, "Musical Instruments Other (Powered)", "10001377" },
                    { 2757, "Percussion Musical Instruments (Powered)", "10000941" },
                    { 2758, "String Musical Instruments (Powered)", "10000942" },
                    { 2759, "Woodwind Musical Instruments (Powered)", "10000943" },
                    { 2760, "Musical Instruments/Accessories Variety Packs", "10004126" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2761, "Anklets", "10001083" },
                    { 2762, "Bracelets", "10001084" },
                    { 2763, "Brooches", "10001085" },
                    { 2764, "Cuff-links", "10001086" },
                    { 2765, "Earrings/Body-piercing Jewellery", "10001087" },
                    { 2766, "Jewellery Boxes/Pouches", "10001088" },
                    { 2767, "Jewellery Other", "10001387" },
                    { 2768, "Jewellery Replacement Parts", "10001089" },
                    { 2769, "Jewellery Variety Packs", "10001388" },
                    { 2770, "Necklaces/Necklets", "10001090" },
                    { 2772, "Rings", "10001092" },
                    { 2693, "Rain Gauges – Non Powered", "10003447" },
                    { 2692, "Pyranometers/Solarimeters – Powered", "10003433" },
                    { 2691, "Psychrometers – Powered", "10003432" },
                    { 2614, "Outdoor Lamps/Torches/Lanterns – Non Powered", "10005216" },
                    { 2615, "Outdoor Lamps/Torches/Lanterns – Powered", "10005215" },
                    { 2616, "Arbours/Bowers", "10003414" },
                    { 2617, "Cold Frames/Propagators/Cloches", "10003421" },
                    { 2618, "Conservatories", "10003415" },
                    { 2619, "Gazebos", "10003412" },
                    { 2620, "Greenhouse Frames", "10003890" },
                    { 2621, "Greenhouses (Complete)", "10003409" },
                    { 2622, "Lawn/Garden Outdoor Structures Other", "10003418" },
                    { 2623, "Lawn/Garden Outdoor Structures Variety Packs", "10003891" },
                    { 2624, "Pagodas (Lawn/Garden)", "10003416" },
                    { 2625, "Plants/Fauna Tunnels", "10003859" },
                    { 2626, "Sheds", "10003411" },
                    { 2627, "Wildlife Habitat", "10006847" },
                    { 2628, "Garden Water Features", "10003215" },
                    { 2629, "Garden/Water Feature Ornaments", "10003315" },
                    { 2630, "Lawn/Garden Pools/Ponds/Water Features Other", "10003225" },
                    { 2631, "Pond/Water Feature Aerators", "10003220" },
                    { 2632, "Pond/Water Feature Foggers", "10003218" },
                    { 2633, "Pool Supplies", "10005253" },
                    { 2634, "Pool/Pond/Water Feature Drainage Pipes", "10003222" },
                    { 2635, "Pool/Pond/Water Feature Filters (Powered)", "10003216" },
                    { 2636, "Pool/Pond/Water Feature Protective Covers", "10003223" },
                    { 2613, "Lawn/Garden Lighting Other", "10005218" },
                    { 2637, "Pool/Pond/Water Feature Shells/Liners", "10003213" },
                    { 2612, "Tampers (Non Powered)", "10003395" },
                    { 2610, "Shovels/Spades", "10003390" },
                    { 2587, "Lawn/Garden Furnishings Variety Packs", "10003252" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2588, "Mail/Post Boxes (Lawn/Garden)", "10005361" },
                    { 2589, "Marquees", "10003417" },
                    { 2590, "Plant Holders", "10003313" },
                    { 2591, "Umbrellas/Parasols", "10005219" },
                    { 2592, "Axes", "10003383" },
                    { 2593, "Bulb Planters", "10003398" },
                    { 2594, "Digging Bars", "10003846" },
                    { 2595, "Edgers (Non Powered)", "10003389" },
                    { 2596, "Garden Carts (Non Powered)", "10003404" },
                    { 2597, "Garden Shears (Non Powered)", "10003379" },
                    { 2598, "Harrows", "10003386" },
                    { 2599, "Lawn Aerators (Non Powered)", "10003393" },
                    { 2600, "Lawn Bags", "10003403" },
                    { 2601, "Lawn Sweeps/Spreaders (Non Powered)", "10003377" },
                    { 2602, "Lawn/Garden Hand Tools Other", "10003865" },
                    { 2603, "Lawn/Garden Hand Tools Variety Packs", "10003866" },
                    { 2604, "Loppers", "10003380" },
                    { 2605, "Mauls", "10003385" },
                    { 2606, "Post Hole Diggers (Non Powered)", "10003844" },
                    { 2607, "Pruners/Secateurs", "10003381" },
                    { 2608, "Rakes", "10003399" },
                    { 2609, "Seed Starters", "10003405" },
                    { 2611, "Sickles/Scythes/Snaths", "10003384" },
                    { 2798, "Pet Food/Drink Dispensers (Non Powered)", "10000642" },
                    { 2638, "Pool/Pond/Water Feature UV Clarifiers/Sterilizers", "10003219" },
                    { 2640, "Chain Saws (Powered)", "10003359" },
                    { 2668, "Garden Water Storage Supplies", "10003268" },
                    { 2669, "Hose Connectors", "10003255" },
                    { 2670, "Hose Storage – Mobile", "10003257" },
                    { 2671, "Hose Storage – Stationary", "10003256" },
                    { 2672, "Hoses", "10003254" },
                    { 2673, "Irrigation Systems", "10003264" },
                    { 2674, "Irrigation Timers/Controllers", "10003276" },
                    { 2675, "Lawn/Garden Watering Equipment Other", "10003274" },
                    { 2676, "Lawn/Garden Watering Equipment Variety Packs", "10003272" },
                    { 2677, "Sprinklers/Sprayers/Misters (Hose End)", "10003262" },
                    { 2678, "Watering Cans", "10003267" },
                    { 2679, "Anemometers – Non Powered", "10003430" },
                    { 2680, "Anemometers – Powered", "10005318" },
                    { 2681, "Barographs – Non Powered", "10003443" },
                    { 2682, "Barometers – Non Powered", "10003441" },
                    { 2683, "Combination Weather Measuring/Monitoring Equipment – Non Powered", "10003444" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2684, "Combination Weather Measuring/Monitoring Equipment – Powered", "10005316" },
                    { 2685, "Evaporimeters/Atmometers – Powered", "10003434" },
                    { 2686, "Hygrometers – Non-Powered", "10003437" },
                    { 2687, "Hygrometers – Powered", "10005323" },
                    { 2688, "Lawn/Garden Weather Monitoring/Observation Other", "10003452" },
                    { 2689, "Lawn/Garden Weather Monitoring/Observation Variety Packs", "10003453" },
                    { 2690, "Light Meters – Powered", "10003436" },
                    { 2667, "Garden Water Pumps", "10003857" },
                    { 2639, "Brush Cutters/String Trimmers/Edgers (Powered)", "10003355" },
                    { 2666, "Outdoor Bins", "10003314" },
                    { 2664, "Garden Incinerators", "10003400" },
                    { 2641, "Chippers/Shredders/Mulchers (Powered)", "10003351" },
                    { 2642, "Cultivators/Tillers/Rotary Hoes (Powered)", "10003373" },
                    { 2643, "Earth Augers (Powered)", "10003365" },
                    { 2644, "Garden Power Tools Other", "10003408" },
                    { 2645, "Garden Vacuums/Blowers", "10003338" },
                    { 2646, "Hedge Trimmers (Powered)", "10003870" },
                    { 2647, "Lawn Scarifiers/Aerators (Powered)", "10003347" },
                    { 2648, "Lawn/Garden Power Tools Replacement Parts/Accessories", "10003402" },
                    { 2649, "Log Splitters (Powered)", "10003367" },
                    { 2650, "Post Hole Diggers (Powered)", "10003861" },
                    { 2651, "Pressure Washers (Powered)", "10003375" },
                    { 2652, "Pruners (Powered)", "10003843" },
                    { 2653, "Stump Grinders/Pullers (Powered)", "10003368" },
                    { 2654, "Tampers (Powered)", "10003370" },
                    { 2655, "Weed Burners (Powered)", "10003401" },
                    { 2656, "Ground Cover/Landscaping/Mulching Fabrics", "10005729" },
                    { 2657, "Lawn/Garden Soil/Soil Amendments Other", "10004110" },
                    { 2658, "Topsoil", "10003236" },
                    { 2659, "Lawn/Garden Testing Diagnostic Equipment Other", "10003887" },
                    { 2660, "Water/Soil Testing Equipment (Non Powered)", "10003238" },
                    { 2661, "Concrete Tiles  - Outdoor Ground", "10006787" },
                    { 2662, "Natural Stone Tiles  - Outdoor Ground", "10006789" },
                    { 2663, "Wooden Tiles - Outdoor Ground", "10006786" },
                    { 2665, "Lawn/Garden Waste Disposal Other", "10003311" },
                    { 2799, "Pet Housing/Bedding (Disposable)", "10000572" },
                    { 2800, "Pet Housing/Bedding (Non Disposable)", "10000662" },
                    { 2801, "Pet Toys (Non Powered)", "10000641" },
                    { 2937, "Weather/Natural Disaster Safety Product Variety Packs", "10005395" },
                    { 2938, "Burglar Alarms", "10005396" },
                    { 2939, "Gas/Heat/Smoke Detectors", "10005397" },
                    { 2940, "Stanchions", "10006231" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2941, "Access Control Security Systems", "10005398" },
                    { 2942, "Door Chains", "10005401" },
                    { 2943, "Door/Gate Entry Intercoms", "10005399" },
                    { 2944, "Door/Gate Viewers", "10005402" },
                    { 2945, "Door/Gate/Window Bolts/Locks/Keys", "10005400" },
                    { 2946, "Door/Window/Perimeter Security Products Variety Packs", "10005406" },
                    { 2947, "Security Doors/Gates", "10005403" },
                    { 2948, "Window Burglar Bars/Panels/Shutters", "10005405" },
                    { 2949, "Fire Blankets", "10005407" },
                    { 2950, "Fire Extinguishers – Pressurised", "10005408" },
                    { 2951, "Fire Hoses", "10005409" },
                    { 2952, "Home/Business Fire Extinguishers Variety Packs", "10005410" },
                    { 2953, "Bugging/Debugging Equipment", "10005411" },
                    { 2954, "Exterior Convex Mirrors", "10005709" },
                    { 2955, "Home/Business Surveillance Equipment Variety Packs", "10005415" },
                    { 2956, "Light/Motion/Sound Sensors", "10005412" },
                    { 2957, "Security Lights", "10005413" },
                    { 2958, "Surveillance Cameras/Video Recorders", "10005414" },
                    { 2959, "Safes", "10005416" },
                    { 2936, "Transponders", "10005394" },
                    { 2960, "Body Alarms", "10005373" },
                    { 2935, "Storm Shelters", "10005393" },
                    { 2933, "Marine Navigation Software", "10005873" },
                    { 2910, "Helmets – Non Powered", "10005110" },
                    { 2911, "Helmets – Powered", "10005109" },
                    { 2912, "Protective Personal Aids Other", "10005116" },
                    { 2913, "Protective Personal Aids Variety Packs", "10005117" },
                    { 2914, "Safety Glasses/Goggles", "10003586" },
                    { 2915, "Baby Harnesses/Reins", "10000796" },
                    { 2916, "Baby Play Pens/Dens", "10000788" },
                    { 2917, "Baby Safety Monitoring (Non Powered)", "10000634" },
                    { 2918, "Baby Safety Monitoring (Powered)", "10000791" },
                    { 2919, "Baby Safety Protection (Non Powered)", "10000503" },
                    { 2920, "Baby Safety/Security/Surveillance - Other", "10006820" },
                    { 2921, "Baby Safety/Security/Surveillance Variety Packs", "10006818" },
                    { 2922, "Fire Escape Chutes/Ladders", "10005384" },
                    { 2923, "Fire Retardants/Suppressants", "10005383" },
                    { 2924, "Public Fire Alarms", "10005385" },
                    { 2925, "Smoke Hoods/Respirators", "10005386" },
                    { 2926, "Air/Fog Horns", "10005388" },
                    { 2927, "Barricade Safety Tapes", "10005725" },
                    { 2928, "Lifebelts/Life-Jackets/Lifesuits", "10005389" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2929, "Liferafts/Life-Buoys/Flotation Cushions", "10005390" },
                    { 2930, "Lightning Detectors – Powered", "10003427" },
                    { 2931, "Lightning Rods/Accessories", "10005391" },
                    { 2932, "Marine Electronic Chartplotters", "10005872" },
                    { 2934, "Sandbags/Flood-guards", "10005392" },
                    { 2909, "Hearing Protection – Powered", "10005107" },
                    { 2961, "Emergency Survival Blankets/Sleeping Bags", "10005472" },
                    { 2963, "Key-ring Alarms", "10005375" },
                    { 2991, "Cycles (Powered)", "10005815" },
                    { 2992, "Fishfinders", "10005870" },
                    { 2993, "Fishing Bait/Flies", "10001915" },
                    { 2994, "Fishing Floats", "10001917" },
                    { 2995, "Fishing Hooks", "10001916" },
                    { 2996, "Fishing Line/Gut", "10001920" },
                    { 2997, "Fishing Nets", "10001918" },
                    { 2998, "Fishing Reels", "10001914" },
                    { 2999, "Fishing Rod Accessories", "10001921" },
                    { 3000, "Fishing Rods/Poles", "10001913" },
                    { 3001, "Fishing/Angling Sports Equipment Other", "10001923" },
                    { 3002, "Gymnastics Apparatus", "10001827" },
                    { 3003, "Gymnastics Sports Equipment Other", "10001830" },
                    { 3004, "Rhythm Gymnastics Equipment", "10001826" },
                    { 3005, "Game Lures/Decoys/Callers", "10001880" },
                    { 3006, "Hunting Field Dressing Equipment", "10001883" },
                    { 3007, "Hunting Sports Aids Other", "10001886" },
                    { 3008, "Kites", "10001831" },
                    { 3009, "Kiting/Parachuting Boards/Buggies (Non Powered)", "10001834" },
                    { 3010, "Kiting/Parachuting Sports Equipment – Replacement Parts/Accessories", "10001835" },
                    { 3011, "Kiting/Parachuting Sports Equipment Other", "10001838" },
                    { 3012, "Parachutes", "10001832" },
                    { 3013, "Exercise Machines (Non Powered)", "10001815" },
                    { 2990, "Cycles (Non Powered)", "10001810" },
                    { 2962, "Emergency Whistles", "10005374" },
                    { 2989, "Cycles – Replacement Parts", "10001811" },
                    { 2987, "Cycle Anti-theft Device", "10006392" },
                    { 2964, "Personal Luggage Alarms", "10005376" },
                    { 2965, "Personal Safety Devices Variety Packs", "10005382" },
                    { 2966, "Personal Safety Flares/Signals", "10005377" },
                    { 2967, "Personal Safety Lights", "10005378" },
                    { 2968, "Remote Controlled Vehicles", "10006850" },
                    { 2969, "Remotely Controlled Vehicle Replacement Parts and Accessories", "10006851" },
                    { 2970, "Self-defence Sprays", "10005379" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2971, "Stun Guns", "10005380" },
                    { 2972, "Wearable Wireless Webcams (Inverse Surveillance)", "10005381" },
                    { 2973, "Safety/Security/Surveillance Variety Packs", "10005418" },
                    { 2974, "Baby Carrier", "10000502" },
                    { 2975, "Baby Carry Cots/Baskets/Cradles", "10000795" },
                    { 2976, "Baby Cot/Basket – Travel", "10000794" },
                    { 2977, "Baby Door Bouncers", "10000802" },
                    { 2978, "Baby Exercisers/Transportation Other", "10000805" },
                    { 2979, "Baby Swings", "10000803" },
                    { 2980, "Pram/Pushchair/Stroller Accessories", "10000797" },
                    { 2981, "Prams/Pushchairs/Strollers", "10000793" },
                    { 2982, "Combat Sports Equipment Other", "10004096" },
                    { 2983, "Fencing Sports Equipment (Non Powered)", "10004112" },
                    { 2984, "Fencing Sports Equipment (Powered)", "10004098" },
                    { 2985, "Martial Arts Sports Equipment", "10001807" },
                    { 2986, "Punching/Kicking Training Aids", "10001806" },
                    { 2988, "Cycle Sports Equipment Variety Packs", "10001812" },
                    { 3015, "Free Weights/Dumb-bells", "10001816" },
                    { 2908, "Hearing Protection – Non Powered", "10005108" },
                    { 2906, "Face Shields/Guards", "10005112" },
                    { 2829, "Duct Boosters", "10003996" },
                    { 2830, "Fans – Ceiling", "10003995" },
                    { 2831, "Fans – Extractor", "10003998" },
                    { 2832, "Fans – Window/Exhaust", "10004064" },
                    { 2833, "Backflow Preventer Parts/Accessories", "10005865" },
                    { 2834, "Backflow Test Kits", "10005863" },
                    { 2835, "Bath Lifts", "10002624" },
                    { 2836, "Bath Seats", "10004027" },
                    { 2837, "Bath/Shower Caddies – Fixed", "10004032" },
                    { 2838, "Bathroom Fittings Variety Packs", "10002627" },
                    { 2839, "Grab Bars", "10004028" },
                    { 2840, "Hand Dryers", "10006232" },
                    { 2841, "Shower Safety Strips", "10004026" },
                    { 2842, "Shower Thermo Alarms", "10002623" },
                    { 2843, "Soap/Lotion/Sanitizer Dispensers", "10004034" },
                    { 2844, "Toilet Seats/Lids", "10004062" },
                    { 2845, "Towel Bars/Hooks/Rings – Fixed", "10004033" },
                    { 2846, "Central Heating Replacement Parts/Accessories", "10002660" },
                    { 2847, "Fireplace Fuel Storage", "10006402" },
                    { 2848, "Fireplace Screens", "10006401" },
                    { 2849, "Fireplaces/Fireplace Surrounds/Mantels", "10005478" },
                    { 2850, "Heating Equipment Variety Packs", "10002662" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2851, "Heating System Controls", "10002653" },
                    { 2828, "Air Purifiers/Ionisers – Fixed", "10003988" },
                    { 2852, "Household Boilers/Furnaces/Tank Water Heaters", "10002658" },
                    { 2827, "Air Monitors", "10006274" },
                    { 2825, "Air Dehumidifiers – Fixed", "10003990" },
                    { 2802, "Pet Toys (Powered)", "10000661" },
                    { 2803, "Pet Training/Control Aids/Accessories (Non Powered)", "10000640" },
                    { 2804, "Pet Training/Control Aids/Accessories (Powered)", "10000652" },
                    { 2805, "Terrarium Aids/Accessories (Non Powered)", "10006843" },
                    { 2806, "Terrarium Aids/Accessories (Powered)", "10006844" },
                    { 2807, "Pet Care Variety Packs", "10000653" },
                    { 2808, "Pet Nutritional Supplements", "10000513" },
                    { 2809, "Pet Nutritional Supplements Other", "10000737" },
                    { 2810, "Pet Parasite Treatment", "10000515" },
                    { 2811, "Pet Grooming Aids", "10000508" },
                    { 2812, "Pet Hygiene/Sanitary Protection", "10000510" },
                    { 2813, "Pet Welfare/Hygiene Other", "10000738" },
                    { 2814, "Pet Care/Food Variety Packs", "10000654" },
                    { 2815, "Pet Drinks (Frozen)", "10000506" },
                    { 2816, "Pet Drinks (Perishable)", "10000523" },
                    { 2817, "Pet Drinks (Shelf Stable)", "10000524" },
                    { 2818, "Pet Food (Frozen)", "10000507" },
                    { 2819, "Pet Food (Perishable)", "10000521" },
                    { 2820, "Pet Food (Shelf Stable)", "10000522" },
                    { 2821, "Pet Food/Drinks Variety Packs", "10000663" },
                    { 2822, "Air Conditioners/Coolers – Fixed", "10003982" },
                    { 2823, "Air Conditioning Equipment – Multifunction – Fixed", "10004063" },
                    { 2824, "Air Conditioning/Cooling/Ventilation Equipment Replacement Parts/Accessories", "10003984" },
                    { 2826, "Air Humidifiers – Fixed", "10003993" },
                    { 2907, "Hard Hats/Caps", "10005111" },
                    { 2853, "Immersion Heaters", "10002657" },
                    { 2855, "Room Heaters", "10005717" },
                    { 2883, "De-scalers (DIY)", "10004006" },
                    { 2884, "Scale Inhibitors", "10002649" },
                    { 2885, "Water Filtration Machines/Systems", "10004016" },
                    { 2886, "Water Meters", "10004012" },
                    { 2887, "Water Softeners (DIY)", "10004008" },
                    { 2888, "Water Storage/Treatment – Accessories/Replacement Parts", "10002650" },
                    { 2889, "Water Storage/Treatment Variety Packs", "10002652" },
                    { 2890, "Water Tanks", "10002646" },
                    { 2891, "Water Treatments (DIY)", "10002648" },
                    { 2892, "Pipes/Tubing", "10004054" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 2893, "Pipes/Tubing – Accessories/Replacement Parts", "10004057" },
                    { 2894, "Pipes/Tubing Connectors", "10004022" },
                    { 2895, "Pipes/Tubing Flanges", "10005867" },
                    { 2896, "Pipes/Tubing Supply Variety Packs", "10004058" },
                    { 2897, "Pipes/Tubing Valves/Fittings", "10004024" },
                    { 2898, "Pumps", "10004055" },
                    { 2899, "Absorbents (DIY)", "10005626" },
                    { 2900, "Antifatigue Aids (DIY)", "10005627" },
                    { 2901, "Antislip Aids (DIY)", "10005628" },
                    { 2902, "Protective Collective Aids Other", "10005646" },
                    { 2903, "Safety Nets/Curtains/Barriers", "10005630" },
                    { 2904, "Environmental Respiratory Protection – Non Powered", "10005106" },
                    { 2905, "Environmental Respiratory Protection – Powered", "10005105" },
                    { 2882, "Waste Traps", "10005480" },
                    { 2854, "Radiators", "10002654" },
                    { 2881, "Plungers", "10003565" },
                    { 2879, "Urinals", "10002587" },
                    { 2856, "Solar Power Stations", "10005875" },
                    { 2857, "Tankless Water Heaters", "10005479" },
                    { 2858, "Thermostats", "10004002" },
                    { 2859, "Underfloor Heating Systems", "10004003" },
                    { 2860, "Plumbing/Heating Ventilation/Air Conditioning Variety Packs", "10003994" },
                    { 2861, "Basin/Sink Pedestals", "10002609" },
                    { 2862, "Basins/Sinks", "10002592" },
                    { 2863, "Bathroom Suites", "10002610" },
                    { 2864, "Bathtub/Shower Doors", "10002600" },
                    { 2865, "Bathtub/Shower Enclosure Panels", "10002601" },
                    { 2866, "Bathtub/Shower Modules", "10002590" },
                    { 2867, "Bathtubs – Jetted (Hot Tubs/Spas)", "10002596" },
                    { 2868, "Bathtubs – Soaking", "10002595" },
                    { 2869, "Bidets", "10002585" },
                    { 2870, "Faucets/Taps", "10002602" },
                    { 2871, "Sanitary Ware – Replacement Parts/Accessories", "10002612" },
                    { 2872, "Sanitary Ware Variety Packs", "10002614" },
                    { 2873, "Shower Heads", "10002608" },
                    { 2874, "Shower Pans/Trays", "10002599" },
                    { 2875, "Sink/Base Combinations", "10002593" },
                    { 2876, "Toilet/Urinal Cisterns", "10002589" },
                    { 2877, "Toilets", "10002586" },
                    { 2878, "Urinal Partitions", "10002588" },
                    { 2880, "Macerators", "10002611" },
                    { 1723, "Winter Melons or Odourless Muskmelons", "10006827" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1943, "Dishwashers", "10001964" },
                    { 1721, "Other Melons", "10006348" },
                    { 568, "Keys", "10003914" },
                    { 569, "Letter Boxes", "10002578" },
                    { 570, "Mezzanine/Attic Ladders", "10002515" },
                    { 571, "Storm/Screen Door Replacement Hardware", "10003916" },
                    { 572, "Cat/Dog Flaps", "10002577" },
                    { 573, "Door Accessories", "10005471" },
                    { 574, "Doors – Bulkhead (Basement)", "10003921" },
                    { 575, "Doors – Exterior", "10002570" },
                    { 576, "Doors – Garage", "10002568" },
                    { 577, "Doors – Interior", "10002567" },
                    { 567, "House identification – Numbers/Letters", "10002579" },
                    { 578, "Doors – Patio", "10002569" },
                    { 580, "Doors Variety Packs", "10003924" },
                    { 581, "Gate/Garage Door Opening Systems", "10005673" },
                    { 582, "Anchors/Wall Plugs (Fixings/Fasteners)", "10003179" },
                    { 583, "Bearings/Bushings", "10003170" },
                    { 584, "Bolts/Threaded Rods", "10003185" },
                    { 585, "Brackets/Braces", "10003186" },
                    { 586, "Catches (Fixings/Fasteners)", "10003187" },
                    { 587, "Fixings/Fasteners Hardware Accessories", "10005670" },
                    { 588, "Fixings/Fasteners Hardware Other", "10003194" },
                    { 589, "Hooks (Fixings/Fasteners)", "10003171" },
                    { 579, "Doors – Storm/Screen Combination", "10003920" },
                    { 566, "Hinges – Door", "10003191" },
                    { 565, "Door Weather Excluders", "10002575" },
                    { 564, "Door Thresholds", "10003906" },
                    { 541, "Curtain Holdbacks", "10005688" },
                    { 542, "Curtain Hooks/Rings", "10003198" },
                    { 543, "Curtain Parts/Accessories Other", "10003201" },
                    { 544, "Curtain Poles/Rods", "10003196" },
                    { 545, "Curtain Rod Brackets", "10003199" },
                    { 546, "Curtain Rod/Track Accessories", "10003767" },
                    { 547, "Curtain Tracks", "10003197" },
                    { 548, "Balustrade/Railing Systems – Non Wood", "10003961" },
                    { 549, "Balustrade/Railing Systems – Wood", "10003962" },
                    { 550, "Deck Drainage Systems", "10002672" },
                    { 551, "Deck Railing Parts", "10002668" },
                    { 552, "Deck Railing Systems – Composite", "10002671" },
                    { 553, "Decking – Composite", "10002669" },
                    { 554, "Decking Accessories", "10002670" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 555, "Decking/Railing Other", "10002673" },
                    { 556, "Stair Railing Systems – Non Wood", "10003960" },
                    { 557, "Stair Railing Systems – Wood", "10003959" },
                    { 558, "Bells/Chimes/Buzzers", "10005560" },
                    { 559, "Door Closers", "10002574" },
                    { 560, "Door Handles/Knobs/Levers", "10002573" },
                    { 561, "Door Hardware Other", "10003918" },
                    { 562, "Door Knockers", "10002581" },
                    { 563, "Door Plates", "10002572" },
                    { 590, "Mounting Rails", "10006794" },
                    { 591, "Nuts (Fixings/Fasteners)", "10003184" },
                    { 592, "Rings/Grommets", "10003166" },
                    { 593, "Rivets (Fixings/Fasteners)", "10003190" },
                    { 621, "Lawn/Ground-Level Drainage Parts/Fittings", "10002663" },
                    { 622, "Insulation – Batts/Rolls/Blankets", "10002454" },
                    { 623, "Insulation – Loose Fill/Spray Foam", "10002456" },
                    { 624, "Insulation – Radiant Barriers/Heat Shields", "10005342" },
                    { 625, "Insulation – Rigid Foam Board (Interior)", "10002455" },
                    { 626, "Insulation Other", "10002460" },
                    { 627, "Insulation Supports/Anchors", "10005345" },
                    { 628, "Insulation Variety Packs", "10002461" },
                    { 629, "Beams (Structural)", "10003927" },
                    { 630, "Engineered Wood (Dimension/Structural)", "10002537" },
                    { 631, "Gypsum/Cement Board", "10002540" },
                    { 632, "Hardwood Lumber (Dimension/Structural)", "10002535" },
                    { 633, "Laths", "10005721" },
                    { 634, "Lumber/Wood Panel/Gypsum Variety Packs", "10003933" },
                    { 635, "Plywood/OSB", "10002538" },
                    { 636, "Poles/Pilings/Rods", "10005424" },
                    { 637, "Softwood Board", "10005355" },
                    { 638, "Softwood Lumber (Dimension/Structural)", "10002536" },
                    { 639, "Iron on Edging Strip/Banding", "10006793" },
                    { 640, "Jambs (Mouldings/Millwork)", "10005428" },
                    { 641, "Millwork – Ornaments", "10003939" },
                    { 1722, "Watermelons", "10006037" },
                    { 643, "Mouldings – Wood", "10003935" },
                    { 620, "Guttering/Drainage Other", "10002666" },
                    { 540, "Building Products - Other", "10006895" },
                    { 619, "Guttering Parts/Fittings", "10002665" },
                    { 617, "Drain Covers (Guttering/Drainage)", "10005668" },
                    { 594, "Ropes/Chains/Cables (Fixings/Fasteners)", "10003167" },
                    { 595, "Screws", "10003181" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 596, "Springs", "10003168" },
                    { 597, "Staples (Fixings/Fasteners)", "10003183" },
                    { 598, "Tubing", "10003173" },
                    { 599, "Washers (Fixings/Fasteners)", "10003180" },
                    { 600, "Entrance Grid/Mat Frame", "10006901" },
                    { 601, "Flooring – Carpet", "10002446" },
                    { 602, "Flooring – Ceramic/Porcelain Tiles", "10002443" },
                    { 603, "Flooring – Cork/Bamboo", "10002449" },
                    { 604, "Flooring – Engineered Wood", "10005370" },
                    { 605, "Flooring – Laminate", "10002451" },
                    { 606, "Flooring – Solid Wood", "10002447" },
                    { 607, "Flooring – Stone/Marble", "10002450" },
                    { 608, "Flooring - Underlay", "10006841" },
                    { 609, "Flooring – Vinyl/Rubber/Linoleum", "10002448" },
                    { 610, "Flooring Accessories", "10002444" },
                    { 611, "Flooring Other", "10002452" },
                    { 612, "Shims/Spacers", "10002532" },
                    { 613, "Glass", "10002584" },
                    { 614, "Glass Block (Grid Systems)", "10003925" },
                    { 615, "Channel (Guttering/Drainage)", "10006902" },
                    { 616, "Down Spout Parts/Fittings", "10003956" },
                    { 618, "Drop Outlets (Guttering/Drainage)", "10003955" },
                    { 539, "Stucco", "10002527" },
                    { 538, "Stone – Stone Pavers", "10002518" },
                    { 537, "Stone – Building Stone", "10003894" },
                    { 460, "Feminine Hygiene – Tampons", "10000320" },
                    { 461, "Feminine Hygiene – Towels/Pads", "10000376" },
                    { 462, "Feminine/Nursing Hygiene Other", "10000785" },
                    { 463, "Nursing Hygiene Accessories", "10000362" },
                    { 464, "Antiperspirants/Deodorants", "10000338" },
                    { 465, "Cotton Wool Products", "10000335" },
                    { 466, "Ear/Nasal Care", "10000341" },
                    { 467, "Facial Tissue/Handkerchiefs (Disposable)", "10000485" },
                    { 468, "General Personal Hygiene Other", "10000786" },
                    { 469, "Toilet Paper", "10000375" },
                    { 470, "Breath Fresheners/Mouth Rinses", "10000536" },
                    { 471, "Dental Cleansing", "10000383" },
                    { 472, "Denture/Orthodontic – Care", "10000336" },
                    { 473, "Denture/Orthodontic – Cleansing", "10000337" },
                    { 474, "Oral Care – Accessories", "10000363" },
                    { 475, "Oral Care – Aids (Non Powered)", "10000384" },
                    { 476, "Oral Care – Aids (Powered)", "10000781" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 477, "Oral Care Centre – Brush/Cleanser/Storage (Powered)", "10005839" },
                    { 478, "Oral Hygiene – Replacement Parts", "10000782" },
                    { 479, "Oral Hygiene Other", "10000783" },
                    { 480, "Personal Hygiene Products Variety Packs", "10000712" },
                    { 481, "Penetration Accessories (Non Powered)", "10006247" },
                    { 482, "Penetration Accessories (Powered)", "10006246" },
                    { 459, "Feminine Hygiene – Panty Liners", "10000483" },
                    { 483, "Suction Devices (Non Powered)", "10006249" },
                    { 458, "Feminine Hygiene – Cups", "10000482" },
                    { 456, "Baby Inserts/Pads", "10000495" },
                    { 433, "Hair Products Variety Packs", "10000676" },
                    { 434, "Bleaching/Lightening Products", "10000329" },
                    { 435, "Depilation/Epilation (Non Powered)", "10000340" },
                    { 436, "Depilation/Epilation (Powered)", "10000830" },
                    { 437, "Hair Removal – Care", "10000350" },
                    { 438, "Hair Removal/Masking Products – Replacement Parts", "10000832" },
                    { 439, "Hair Removal/Masking Products Variety Packs", "10000680" },
                    { 440, "Hair Removal/Shaving – Accessories", "10000349" },
                    { 441, "Mirrors – Personal Care", "10000679" },
                    { 442, "Shaving – Blades", "10000369" },
                    { 443, "Shaving – Razors – Disposable (Non Powered)", "10000370" },
                    { 444, "Shaving – Razors – Non Disposable (Non Powered)", "10000730" },
                    { 445, "Shaving – Razors (Powered)", "10000831" },
                    { 446, "Shaving Preparations", "10000535" },
                    { 447, "Adult Incontinence – Pads", "10000481" },
                    { 448, "Adult Incontinence – Supplies", "10000321" },
                    { 449, "Adult Incontinence – Underwear (Disposable)", "10000709" },
                    { 450, "Adult Incontinence – Underwear (Non Disposable)", "10000710" },
                    { 451, "Adult Incontinence Other", "10000784" },
                    { 452, "Baby Diapers (Disposable)", "10000494" },
                    { 453, "Baby Diapers (Non Disposable)", "10000728" },
                    { 454, "Baby Diapers Accessories", "10000496" },
                    { 455, "Baby Diapers/Accessories Other", "10006821" },
                    { 457, "Feminine Hygiene – Accessories", "10000344" },
                    { 644, "Mouldings/Millwork/Stair Parts Other", "10005431" },
                    { 484, "Suction Devices (Powered)", "10006248" },
                    { 486, "Body Washing Other", "10000813" },
                    { 514, "Abrasives Variety Packs", "10003164" },
                    { 515, "Emery Cloths/Sheets", "10003159" },
                    { 516, "Floor Screeds", "10003766" },
                    { 517, "Mineral Abrasives", "10003162" },
                    { 518, "Polishing Compound", "10003765" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 519, "Sandpaper", "10003156" },
                    { 520, "Wire Brushes", "10005715" },
                    { 521, "Access Covers/Panels", "10006900" },
                    { 522, "Aggregate", "10002521" },
                    { 523, "Asphalt/Concrete Patching", "10003898" },
                    { 524, "Asphalt/Concrete/Masonry Other", "10003904" },
                    { 525, "Asphalt/Concrete/Masonry Replacement Parts/Accessories", "10005632" },
                    { 526, "Asphalt/Concrete/Masonry Variety Packs", "10003903" },
                    { 527, "Brick/Block", "10002525" },
                    { 528, "Cement", "10002526" },
                    { 529, "Concrete Air-entraining Agents", "10003901" },
                    { 530, "Concrete Colouring Agents/Dyes", "10003900" },
                    { 531, "Concrete Mixes", "10002522" },
                    { 532, "Lime (DIY)", "10002529" },
                    { 533, "Mortar Mixes", "10003902" },
                    { 534, "Plaster Mixes", "10002528" },
                    { 535, "Plaster of Paris (Agent)", "10003896" },
                    { 536, "Sand (DIY)", "10003897" },
                    { 513, "Abrasives Replacement Parts-Accessories", "10005124" },
                    { 485, "Bath Additives", "10000328" },
                    { 512, "Abrasives Other", "10003163" },
                    { 510, "Sunless Tanning (Powered)", "10000809" },
                    { 487, "Cleansing/Washing Accessories – Personal", "10000334" },
                    { 488, "Cleansing/Washing/Soap – Body", "10000330" },
                    { 489, "Wipes – Personal", "10000573" },
                    { 490, "After Shave Care", "10000324" },
                    { 491, "After-Sun Moisturisers", "10006275" },
                    { 492, "Anti-spot Aids (Non Powered)", "10000327" },
                    { 493, "Anti-spot Aids (Powered)", "10000806" },
                    { 494, "Cleansers/Cosmetics Removers (Non Powered)", "10000332" },
                    { 495, "Cleansers/Cosmetics Removers (Powered)", "10000808" },
                    { 496, "Cooling Face/Body Misters", "10000719" },
                    { 497, "Exfoliants/Masks", "10000342" },
                    { 498, "Lip Balms", "10005727" },
                    { 499, "Skin Care – Replacement Parts", "10000810" },
                    { 500, "Skin Care Variety Packs", "10000721" },
                    { 501, "Skin Care/Moisturising Products", "10000356" },
                    { 502, "Skin Drying Powder", "10000374" },
                    { 503, "Toners/Astringents", "10000484" },
                    { 504, "Skin Products Variety Packs", "10000717" },
                    { 505, "Skin Tanning Products Other", "10000814" },
                    { 506, "Sun Protection Products", "10000373" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 507, "Sun Tan Accelerator Products", "10000388" },
                    { 508, "Sunless Tanning – Oral (Non Powered)", "10000731" },
                    { 509, "Sunless Tanning – Topical (Non Powered)", "10000355" },
                    { 511, "Abrasive Pads/Steel Wool", "10003157" },
                    { 645, "Newel Posts", "10002512" },
                    { 646, "Stair Replacement Parts/Fittings", "10005425" },
                    { 647, "Stairs – Prefabricated", "10002507" },
                    { 783, "Scratch Remover Kit/Repairs", "10000556" },
                    { 784, "Surface Care Other", "10000749" },
                    { 785, "Surface Care/Protection", "10000434" },
                    { 786, "Cleaning/Hygiene Products Variety Packs", "10000694" },
                    { 787, "Dispensers for Cleaning/Hygiene Products", "10006215" },
                    { 788, "Insect/Pest Control – Barriers/Traps", "10000411" },
                    { 789, "Insect/Pest/Allergen Control Other", "10000754" },
                    { 790, "Insecticides/Pesticides/Rodenticides", "10000435" },
                    { 791, "Non Personal Repellents", "10000436" },
                    { 792, "Refuse / Waste Bins", "10002125" },
                    { 793, "Refuse Bags", "10001761" },
                    { 794, "Waste Storage Products - Other", "10006817" },
                    { 795, "Waste Storage Products Variety Packs", "10006815" },
                    { 796, "Belts/Braces/Cummerbunds", "10001326" },
                    { 797, "Clothing Accessories Variety Packs", "10001354" },
                    { 798, "Clothing Adornment/Floral Accessories/Badges/Buckles", "10001331" },
                    { 799, "Clothing/Fashion Tape", "10006903" },
                    { 800, "Handkerchiefs", "10001327" },
                    { 801, "Handwear", "10001328" },
                    { 802, "Headwear", "10001329" },
                    { 803, "Neckwear", "10001330" },
                    { 804, "Clothing Variety Packs", "10002102" },
                    { 805, "Dresses", "10001333" },
                    { 782, "Laundry Other", "10000747" },
                    { 806, "Full Body Wear Variety Packs", "10001355" },
                    { 781, "Laundry Dry Cleaning", "10000444" },
                    { 779, "Laundry Colour Care", "10000427" },
                    { 756, "Descalers", "10000442" },
                    { 757, "Dish Care/Protection", "10000445" },
                    { 758, "Dish Cleaning/Care – Automatic", "10000406" },
                    { 759, "Dish Cleaning/Care – Hand", "10000636" },
                    { 760, "Disinfectants", "10000441" },
                    { 761, "Drain Treatments/Pipe Unblockers", "10000423" },
                    { 762, "Food Treatments", "10006233" },
                    { 763, "Mould/Mildew Removers", "10000440" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 764, "Paper Towels", "10000447" },
                    { 765, "Sanitizers", "10006234" },
                    { 766, "Stain Removers", "10000443" },
                    { 767, "Surface Cleaners", "10000405" },
                    { 768, "Toilet Cleaning Products", "10000426" },
                    { 769, "Water Softeners", "10000446" },
                    { 770, "Cleaning Variety Packs", "10000702" },
                    { 771, "Air Fresheners/Deodorisers (Non Powered)", "10000402" },
                    { 772, "Air Fresheners/Deodorisers (Powered)", "10000696" },
                    { 773, "Fresheners – Fabric", "10000740" },
                    { 774, "Fresheners/Deodorisers Other", "10000745" },
                    { 775, "Detergent Boosters/Laundry Bleaches", "10000743" },
                    { 776, "Fabric Finishers/Starch", "10000742" },
                    { 777, "Fabric Protectors", "10000741" },
                    { 778, "Fabric Softeners/Conditioners", "10000744" },
                    { 780, "Laundry Detergents", "10000424" },
                    { 755, "Cleaning Aids", "10000397" },
                    { 807, "Overalls/Bodysuits", "10001332" },
                    { 809, "Skirts", "10001334" },
                    { 837, "Pantyhose/Stockings", "10002425" },
                    { 838, "Petticoats/Underskirts/Slips", "10002424" },
                    { 839, "Socks", "10001348" },
                    { 840, "Suspenders/Garters", "10002426" },
                    { 841, "Undershirts/Chemises/Camisoles", "10001349" },
                    { 842, "Underwear Variety Packs", "10001360" },
                    { 843, "Jackets/Blazers/Cardigans/Waistcoats", "10001350" },
                    { 844, "Shirts/Blouses/Polo Shirts/T-shirts", "10001352" },
                    { 845, "Sweaters/Pullovers", "10001351" },
                    { 846, "Upper Body Wear/Tops Variety Packs", "10001361" },
                    { 847, "Caller id Displays", "10001174" },
                    { 848, "Communication Accessories Other", "10001379" },
                    { 849, "Communication Headphones Replacement Parts/Accessories", "10005745" },
                    { 850, "Communications Hands Free Kits/Headphones", "10001181" },
                    { 851, "Digital Enhanced Cordless Telecommunications (DECT) Repeaters", "10005740" },
                    { 852, "Mobile Phone Cases", "10001178" },
                    { 853, "Mobile Phone Fascias", "10001182" },
                    { 854, "Mobile Phone Radiation Guards", "10001183" },
                    { 855, "Phone Holders", "10001177" },
                    { 856, "Telephone Wipes", "10005680" },
                    { 857, "Answering Machines", "10001184" },
                    { 858, "Conferencing Systems", "10001185" },
                    { 859, "Fax Machine Consumables", "10005677" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 836, "Pants/Briefs/Undershorts", "10001347" },
                    { 808, "Lower Body Wear/Bottoms Variety Packs", "10001356" },
                    { 835, "Full Body Underwear", "10001346" },
                    { 833, "Sportswear Variety Packs", "10001359" },
                    { 810, "Trousers/Shorts", "10001335" },
                    { 811, "Baby Feeding – Bibs", "10000732" },
                    { 812, "Protective Full Body Wear", "10001394" },
                    { 813, "Protective Handwear", "10001395" },
                    { 814, "Protective Lower Body Wear", "10001397" },
                    { 815, "Protective Upper Body Wear", "10001398" },
                    { 816, "Protective Wear Accessories", "10003704" },
                    { 817, "Protective Wear Variety Packs", "10003705" },
                    { 818, "Dressing Gowns", "10001338" },
                    { 819, "Night Dresses/Shirts", "10001339" },
                    { 820, "Sleep Headwear", "10001340" },
                    { 821, "Sleep Trousers/Shorts", "10001341" },
                    { 822, "Sleepwear Variety Packs", "10001358" },
                    { 823, "Sportswear – Badges/Buckles", "10004115" },
                    { 824, "Sportswear – Belts", "10004114" },
                    { 825, "Sportswear – Full Body Wear", "10001342" },
                    { 826, "Sportswear – Handwear", "10003707" },
                    { 827, "Sportswear – Headwear", "10003708" },
                    { 828, "Sportswear – Lower Body Wear", "10001343" },
                    { 829, "Sportswear – Neckwear", "10004113" },
                    { 830, "Sportswear - Other", "10006840" },
                    { 831, "Sportswear – Upper Body Wear", "10001344" },
                    { 832, "Sportswear Hosiery", "10003709" },
                    { 834, "Bras/Basques/Corsets", "10001345" },
                    { 432, "Hair Curlers/Rollers", "10000829" },
                    { 754, "Cleaning Accessories", "10000398" },
                    { 752, "Bleach", "10000531" },
                    { 675, "Sealants/Fillers/Adhesives Other", "10003210" },
                    { 676, "Tape (DIY)", "10003206" },
                    { 677, "Exterior Trim – Corbels/Pediments", "10003966" },
                    { 678, "Exterior Trim – Siding", "10002677" },
                    { 679, "Exterior Trim – Siding Accessories", "10005705" },
                    { 680, "Exterior Trim – Skirting/Underpinning", "10005731" },
                    { 681, "Exterior Trim – Veneers", "10003969" },
                    { 682, "Columns (Structural)", "10002530" },
                    { 683, "Floor Trusses", "10002533" },
                    { 684, "I-Beams", "10002534" },
                    { 685, "Mobile Home Assembly/Set-up Equipment", "10005732" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 686, "Roof Trusses", "10005659" },
                    { 687, "Structural Components/Assemblies Replacement Parts/Accessories", "10003943" },
                    { 688, "Ceiling Coverings – Panneling/Tiles", "10003980" },
                    { 689, "Ceiling Grid Systems", "10003981" },
                    { 690, "Coping Stones", "10006791" },
                    { 691, "Corner Guards", "10005722" },
                    { 692, "Wall Coverings – Rolls", "10002429" },
                    { 693, "Wall Coverings – Sheets/Panels/Slabs", "10002433" },
                    { 694, "Wall Coverings – Tiles", "10002431" },
                    { 695, "Wall/Ceiling Covering Accessories", "10002432" },
                    { 696, "Wall/Ceiling Coverings Other", "10002441" },
                    { 697, "Awnings – Non Powered", "10005291" },
                    { 674, "Sealants", "10003204" },
                    { 698, "Awnings – Powered", "10002551" },
                    { 673, "Grout", "10003203" },
                    { 671, "Fillers", "10003205" },
                    { 648, "Air Hopper Guns/Sprayers", "10005805" },
                    { 649, "Decorative (Faux) Painting Equipment", "10005730" },
                    { 650, "Dust Sheets/Drop Sheets", "10002490" },
                    { 651, "Household Paint Brushes/Rollers/Applicators", "10005708" },
                    { 652, "Household Paints/Primers", "10003874" },
                    { 653, "Paint Additives/Enhancers", "10005655" },
                    { 654, "Paint/Stain Strainers", "10005706" },
                    { 655, "Paint/Varnish Removers/Cleaners", "10002501" },
                    { 656, "Painting Masking Paper/Film", "10005724" },
                    { 657, "Painting Other", "10002505" },
                    { 658, "Preservers/Preservatives", "10005657" },
                    { 659, "Special Purpose Paints", "10002462" },
                    { 660, "Trim Paints", "10005687" },
                    { 661, "Wood Finish/Treatments/Coatings", "10002466" },
                    { 662, "Roll Roofing", "10002684" },
                    { 663, "Roof Coatings", "10002688" },
                    { 664, "Roofing – Thatch", "10003974" },
                    { 665, "Roofing Accessories", "10003977" },
                    { 666, "Roofing Membranes", "10002687" },
                    { 667, "Roofing Panels/Slabs", "10002686" },
                    { 668, "Roofing Tiles/Slates/Shingles/Shakes", "10002683" },
                    { 669, "Roofing Variety Packs", "10002693" },
                    { 670, "Caulking", "10003208" },
                    { 672, "Glue/Adhesive", "10003207" },
                    { 753, "Cleaners Other", "10000746" },
                    { 699, "Window Balances", "10002557" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 701, "Window Locks/Bolts", "10002548" },
                    { 729, "Camping Water Purification Treatments", "10005198" },
                    { 730, "Camping Beds/Sleeping Mats", "10002079" },
                    { 731, "Camping Furniture/Furnishings Other", "10002085" },
                    { 732, "Camping Seating", "10002081" },
                    { 733, "Camping Storage", "10002083" },
                    { 734, "Camping Tables", "10002084" },
                    { 735, "Sleeping Bags", "10002080" },
                    { 736, "Camping Heating/Lighting Equipment Other", "10002077" },
                    { 737, "Camping Lanterns", "10002076" },
                    { 738, "Camping Water Heaters", "10004099" },
                    { 739, "Tent Heaters", "10002075" },
                    { 740, "Camping Variety Packs", "10002101" },
                    { 741, "Camping Showers", "10002097" },
                    { 742, "Camping Toilets (Non Powered)", "10002096" },
                    { 743, "Camping Toilets (Powered)", "10004100" },
                    { 744, "Camping Washing/Sanitary Equipment – Replacement Parts/Accessories", "10002098" },
                    { 745, "Camping Washing/Sanitary Equipment Other", "10002099" },
                    { 746, "Tent Accessories", "10002072" },
                    { 747, "Tent Treatments/Repair Kits", "10002071" },
                    { 748, "Tents", "10002069" },
                    { 749, "Tents/Weather Structures Other", "10002073" },
                    { 750, "Weather Structures/Tent Extensions", "10002070" },
                    { 751, "Baby Hygiene Products", "10000505" },
                    { 728, "Camping Water Equipment", "10002088" },
                    { 700, "Window Frames", "10002543" },
                    { 727, "Camping Tableware", "10003773" },
                    { 725, "Camping Cool Boxes/Bags (Non Powered)", "10002091" },
                    { 702, "Window Parts/Accessories Other", "10005292" },
                    { 703, "Window Screens", "10002550" },
                    { 704, "Window Shutters", "10003968" },
                    { 705, "Window Wells", "10002554" },
                    { 706, "Windows – Replacement Sash – Wood", "10005294" },
                    { 707, "Windowsill", "10006792" },
                    { 708, "Skylights – Clad Wood", "10005289" },
                    { 709, "Skylights – Non Wood", "10002544" },
                    { 710, "Skylights – Tubular", "10005288" },
                    { 711, "Windows – Bay/Bow – Clad Wood", "10005297" },
                    { 712, "Windows – Bay/Bow – Non Wood", "10005296" },
                    { 713, "Windows – Bay/Bow – Wood", "10005295" },
                    { 714, "Windows – Combination Units – Clad Wood", "10005287" },
                    { 715, "Windows – Combination Units – Non Wood", "10005286" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 716, "Windows – Combination Units – Wood", "10002542" },
                    { 717, "Windows – Other", "10005290" },
                    { 718, "Windows – Single Units – Clad Wood", "10005284" },
                    { 719, "Windows – Single Units – Non Wood", "10005285" },
                    { 720, "Windows – Single Units – Wood", "10003946" },
                    { 721, "Windows – Storm", "10002553" },
                    { 722, "Camping Cooking/Drinking/Eating Equipment – Replacement Parts/Accessories", "10002093" },
                    { 723, "Camping Cooking/Drinking/Eating Equipment Other", "10002094" },
                    { 724, "Camping Cookware", "10002092" },
                    { 726, "Camping Stoves/Grills/Ovens", "10002087" },
                    { 860, "Fax Machines", "10001186" },
                    { 431, "Hair Care Products Variety Packs", "10000677" },
                    { 429, "Hair – Styling (Powered)", "10000678" },
                    { 137, "Audio (Non-Music) – Digital", "10006240" },
                    { 138, "Audio Cassettes – Pre-recorded", "10001464" },
                    { 139, "CD/MD – Pre-recorded", "10001459" },
                    { 140, "Dual Discs – Pre-recorded", "10003718" },
                    { 141, "DVD – Pre-recorded", "10001460" },
                    { 142, "Graphics – Digital", "10006245" },
                    { 143, "Music – Digital", "10006239" },
                    { 144, "Pre-recorded Media Variety Packs", "10001465" },
                    { 145, "Television Shows – Digital", "10006244" },
                    { 146, "Video Cassettes – Pre-recorded", "10001463" },
                    { 136, "Video Recording/Playback – Replacement Parts/Accessories", "10001414" },
                    { 147, "Vinyl – Pre-recorded", "10001462" },
                    { 149, "CD/MD – Recordable", "10001450" },
                    { 150, "DVD – Recordable", "10001451" },
                    { 151, "Floppy Discs", "10001456" },
                    { 152, "Memory Cards", "10001452" },
                    { 153, "Recordable Media Other", "10001458" },
                    { 154, "USB Flash Drives/Thumb Drives", "10006398" },
                    { 155, "Video Cassettes – Recordable", "10001455" },
                    { 156, "Audio Visual/Photography Variety Packs", "10003777" },
                    { 157, "Car Audio – Replacement Parts/Accessories", "10001533" },
                    { 158, "Car Audio Aerials", "10001531" },
                    { 148, "Audio Cassettes – Recordable", "10001449" },
                    { 135, "Video Hard Disc Recorders", "10001410" },
                    { 134, "Video Cassette Players/Recorders", "10001412" },
                    { 133, "Memory Card Recorders", "10005748" },
                    { 110, "Portable FM (Frequency Modulation) Transmitters", "10005765" },
                    { 111, "Portable MD Players", "10001417" },
                    { 112, "Portable MP3 Players", "10001418" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 113, "Portable PA (Public Address) Music Systems", "10005807" },
                    { 114, "Portable Radio-recorders", "10001423" },
                    { 115, "Portable Radios", "10001422" },
                    { 116, "Portable Speakers", "10005710" },
                    { 117, "Television Combinations", "10001401" },
                    { 118, "Televisions", "10001400" },
                    { 119, "Televisions – Hand-held", "10001402" },
                    { 120, "Televisions – Replacement Parts/Accessories", "10001404" },
                    { 121, "Televisions Variety Packs", "10001403" },
                    { 122, "Aerials", "10001411" },
                    { 123, "Audio/Visual Receivers", "10005841" },
                    { 124, "Low-noise Block (LNB) Converters", "10005736" },
                    { 125, "Satellite Reception Accessories", "10005760" },
                    { 126, "Satellite/Terrestrial Antenna Systems", "10005829" },
                    { 127, "Set-top Boxes", "10001409" },
                    { 128, "Video Receiving/Installation Accessories", "10005738" },
                    { 129, "Video Receiving/Installation Variety Packs", "10005739" },
                    { 130, "Camcorders", "10001406" },
                    { 131, "Combination Players/Recorders", "10001408" },
                    { 132, "DVD Players/Recorders", "10001407" },
                    { 159, "Car Audio Amplifiers", "10001530" },
                    { 160, "Car Audio Cassette Players/Changers", "10005205" },
                    { 161, "Car Audio CD Players/Changers", "10001527" },
                    { 162, "Car Audio Head Units", "10001525" },
                    { 190, "Photograph Albums/Cubes", "10001495" },
                    { 191, "Photographic Camera Filters", "10005755" },
                    { 192, "Photographic Film", "10001490" },
                    { 193, "Photographic Slide Projectors", "10001492" },
                    { 194, "Photographic Slide Storage", "10005752" },
                    { 195, "Photographic Slides", "10001493" },
                    { 196, "Photographic Slides – Replacement Parts/Accessories", "10005751" },
                    { 197, "Photographic Studio Flash Gun", "10005753" },
                    { 198, "Photography – Replacement Parts/Accessories", "10001494" },
                    { 199, "Photography Other", "10001498" },
                    { 200, "Photograph Developing Chemicals", "10001507" },
                    { 201, "Photograph Enlargers", "10001508" },
                    { 202, "Photographic Paper", "10001510" },
                    { 203, "Photography Dark Room Safelights", "10001512" },
                    { 204, "Photography Dark Room Tanks/Trays/Reels", "10001513" },
                    { 205, "Photography Drying Equipment", "10001511" },
                    { 206, "Photography Printing/Dark Room Equipment – Replacement Parts/Accessories", "10001515" },
                    { 207, "Photography Printing/Dark Room Equipment Other", "10001516" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 208, "Photography/Optics Variety Packs", "10003686" },
                    { 209, "Antifreeze/Coolants (Automotive)", "10005234" },
                    { 210, "Anti-theft Products Other", "10003009" },
                    { 211, "Anti-theft Products Replacement Parts/Accessories", "10005129" },
                    { 212, "Anti-theft Products Variety Packs", "10003010" },
                    { 189, "Photograph Albums – Replacement Parts/Accessories", "10005207" },
                    { 109, "Portable DVD Players", "10001420" },
                    { 188, "Mobile Photo Storage", "10005842" },
                    { 186, "Digital Cameras", "10001487" },
                    { 163, "Car Audio MD Players/Changers", "10001528" },
                    { 164, "Car Audio Other", "10001534" },
                    { 165, "Car Audio Speakers", "10001529" },
                    { 166, "Car Audio Subwoofers", "10005828" },
                    { 167, "Car Audio Tuners/Receivers", "10001526" },
                    { 168, "Car Audio Variety Packs", "10001532" },
                    { 169, "Car DVD Players", "10001519" },
                    { 170, "Car GPS Antennae", "10005749" },
                    { 171, "Car Navigation Equipment", "10001517" },
                    { 172, "Car Radar Detectors", "10005728" },
                    { 173, "Car Video Cassette Players", "10001520" },
                    { 174, "Car Video Monitors", "10001518" },
                    { 175, "Car Video Receiving Equipment", "10001521" },
                    { 176, "Car Video/Navigation – Replacement Parts/Accessories", "10001523" },
                    { 177, "Car Video/Navigation Other", "10001524" },
                    { 178, "In-car Electronics Variety Packs", "10003685" },
                    { 179, "Binoculars", "10001499" },
                    { 180, "Magnifying Glasses", "10003776" },
                    { 181, "Monoculars/Telescopes", "10001501" },
                    { 182, "Optics Other", "10001506" },
                    { 183, "Analogue Cameras", "10001486" },
                    { 184, "Camera Flash Accessories", "10005750" },
                    { 185, "Camera Flashes", "10001489" },
                    { 187, "Digital Photo Frames", "10005700" },
                    { 108, "Portable Digital Video Players", "10001421" },
                    { 107, "Portable CD Players", "10001416" },
                    { 106, "Portable Audio/Video Variety Packs", "10001426" },
                    { 29, "Jewellery Craft Materials", "10001717" },
                    { 30, "Jewellery Craft Supplies Other", "10001720" },
                    { 31, "Foam Craft Materials", "10005713" },
                    { 32, "Lace/Ribbons/Cords/Braids", "10001700" },
                    { 33, "Needlework Accessories", "10001714" },
                    { 34, "Needlework Fabrics/Textiles", "10001699" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 35, "Needlework Fasteners", "10001710" },
                    { 36, "Needlework Hand/Machine Tools", "10001702" },
                    { 37, "Needlework Marking Equipment", "10001705" },
                    { 38, "Needlework Storage", "10001712" },
                    { 39, "Needlework Templates", "10001713" },
                    { 40, "Needlework Threads", "10001701" },
                    { 41, "Needlework/Toy Making Craft Supplies Other", "10001716" },
                    { 42, "Sewing/Knitting Machinery (Non Powered)", "10001706" },
                    { 43, "Sewing/Knitting Machinery (Powered)", "10001707" },
                    { 44, "Toy Making Accessories", "10001711" },
                    { 45, "Paper Craft Tools (Non Powered)", "10001726" },
                    { 46, "Paper Craft/Card Making Supplies Other", "10001730" },
                    { 47, "Paper/Card Making Craft Accessories", "10001727" },
                    { 48, "Printing Craft Supplies Other", "10001753" },
                    { 49, "Printing Craft Tools", "10001748" },
                    { 50, "Printing Press (Non Powered)", "10001750" },
                    { 51, "Kilns (Powered)", "10001694" },
                    { 28, "Jewellery Craft Accessories", "10001718" },
                    { 52, "Pottery Wheels (Non Powered)", "10001696" },
                    { 27, "Glasswork/Enamelling/Marquetry Craft Supplies Other", "10001735" },
                    { 25, "Glasswork Craft Tools (Powered)", "10001732" },
                    { 2, "Airbrushing Equipment – Replacement Parts/Accessories", "10001688" },
                    { 3, "Airbrushing Supplies Other", "10001690" },
                    { 4, "Artists Accessories", "10001682" },
                    { 5, "Artists Brushes/Applicators", "10001674" },
                    { 6, "Artists Canvas/Pre-primed Boards", "10001679" },
                    { 7, "Artists Drawing Boards", "10005372" },
                    { 8, "Artists Easels", "10001681" },
                    { 9, "Artists Painting Surface Agents", "10001678" },
                    { 10, "Artists Painting/Drawing Supplies Other", "10001685" },
                    { 11, "Artists Paints/Dyes", "10001676" },
                    { 12, "Artists Palettes", "10001680" },
                    { 13, "Artists Pastels/Charcoal/Crayons", "10001677" },
                    { 14, "Sand Art Supplies", "10001683" },
                    { 15, "Arts/Crafts Variety Packs", "10001760" },
                    { 16, "Basketry Craft Accessories", "10001723" },
                    { 17, "Basketry Craft Materials", "10001721" },
                    { 18, "Basketry Craft Supplies Other", "10001725" },
                    { 19, "Basketry Craft Tools (Non Powered)", "10001722" },
                    { 20, "Candle/Soap Craft Materials", "10001736" },
                    { 21, "Candle/Soap Craft Moulds", "10001737" },
                    { 22, "Candle/Soap Craft Supplies Variety Packs", "10001740" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 23, "Candle/Soap Craft Tools (Non Powered)", "10001738" },
                    { 24, "Candle/Soap Craft Tools (Powered)", "10001739" },
                    { 26, "Glasswork/Enamelling/Marquetry Craft Materials", "10001731" },
                    { 213, "Car Alarms/Anti-jacking Alarms", "10003004" },
                    { 53, "Pottery Wheels (Powered)", "10001695" },
                    { 55, "Sculptors Tools (Powered)", "10001693" },
                    { 83, "Wireless Television Links", "10001469" },
                    { 84, "Audio Visual Equipment Variety Packs", "10001485" },
                    { 85, "Home Audio Amplifiers/Preamplifiers", "10001429" },
                    { 86, "Home Audio Cassette Decks", "10001432" },
                    { 87, "Home Audio CD Decks", "10001433" },
                    { 88, "Home Audio Effects Equipment", "10001443" },
                    { 89, "Home Audio Equipment – Replacement Parts/Accessories", "10001447" },
                    { 90, "Home Audio Equipment Other", "10001448" },
                    { 91, "Home Audio Jukeboxes", "10001440" },
                    { 92, "Home Audio Karaoke Systems", "10001441" },
                    { 93, "Home Audio MD Decks", "10001434" },
                    { 94, "Home Audio Receivers/Tuners/Radios", "10001437" },
                    { 95, "Home Audio Speaker Systems", "10001436" },
                    { 96, "Home Audio Speakers – Individual", "10001435" },
                    { 97, "Home Audio/Visual Mixers", "10001442" },
                    { 98, "Home Stereo Systems", "10001430" },
                    { 99, "Home Theatre Systems", "10001431" },
                    { 100, "Turntables – CD", "10001444" },
                    { 101, "Turntables – Vinyl", "10001439" },
                    { 102, "Clock Radios", "10001424" },
                    { 103, "Dictation Machines", "10001425" },
                    { 104, "Portable Audio Cassette Players", "10001419" },
                    { 105, "Portable Audio/Video – Replacement Parts/Accessories", "10001427" },
                    { 82, "Vibration Absorbers/Dampers", "10005746" },
                    { 54, "Sculptors Tools (Non Powered)", "10001692" },
                    { 81, "Universal Remote Controls", "10001470" },
                    { 79, "Switch-boxes", "10001472" },
                    { 56, "Sculptors/Pottery Craft Materials", "10001691" },
                    { 57, "Sculptors/Pottery Craft Supplies Other", "10001698" },
                    { 58, "Spinning/Weaving Craft – Replacement Parts/Accessories", "10001757" },
                    { 59, "Spinning/Weaving Craft Supplies Other", "10001758" },
                    { 60, "Spinning/Weaving Fibres/Yarns", "10001756" },
                    { 61, "Spinning/Weaving Machines (Non Powered)", "10001755" },
                    { 62, "Spinning/Weaving Machines (Powered)", "10001754" },
                    { 63, "Wood Burning/Engraving Craft – Replacement Parts/Accessories", "10001744" },
                    { 64, "Wood Burning/Engraving Craft Tools (Non Powered)", "10001743" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 65, "Wood Burning/Engraving Craft Tools (Powered)", "10001742" },
                    { 66, "Analogue/Digital Converters", "10005726" },
                    { 67, "Audio Headsets", "10001467" },
                    { 68, "Audio Visual Accessories – Replacement Parts", "10001483" },
                    { 69, "Audio Visual Accessories Variety Packs", "10001482" },
                    { 70, "Audio Visual Bags/Boxes/Cases/Wallets", "10001478" },
                    { 71, "Audio Visual Cleaning Products", "10001480" },
                    { 72, "Audio Visual Labelling Systems", "10005744" },
                    { 73, "Audio Visual Stands/Brackets", "10001477" },
                    { 74, "Converter Cassettes", "10001475" },
                    { 75, "Megaphones", "10005204" },
                    { 76, "Microphones", "10001476" },
                    { 77, "MP3 Docking Stations", "10005747" },
                    { 78, "Sound-active Effect Lighting", "10005809" },
                    { 80, "Television Internet Packs", "10001479" },
                    { 214, "Immobilisers (Automotive)", "10005241" },
                    { 215, "Locking Devices", "10003755" },
                    { 216, "Tracking Devices", "10003008" },
                    { 352, "Towing/Hitch Variety Packs", "10002977" },
                    { 353, "Brake Controls", "10002979" },
                    { 354, "Power Modules", "10002980" },
                    { 355, "Towing/Hitch – Electrical Other", "10002985" },
                    { 356, "Wiring Adapters/Converters", "10002981" },
                    { 357, "Couplers – Trailer (Automotive)", "10002988" },
                    { 358, "Trailer Brakes", "10002989" },
                    { 359, "Trailer Jacks/Stands", "10002987" },
                    { 360, "Trailer/Trailer Accessories Other", "10002996" },
                    { 361, "Trailers", "10002993" },
                    { 362, "Transmission Fluid", "10002799" },
                    { 363, "Transmission Fluid Variety Packs", "10002801" },
                    { 364, "Tyres", "10002924" },
                    { 365, "Wheels", "10002926" },
                    { 366, "Beauty/Trim Rings", "10002935" },
                    { 367, "Disc Brake Simulators", "10002934" },
                    { 368, "Jumper Cables", "10006838" },
                    { 369, "Tyre Holder", "10006839" },
                    { 370, "Tyre Inflators – Chemical (Automotive)", "10002932" },
                    { 371, "Tyre Pumps (Automotive)", "10002928" },
                    { 372, "Wheel Hardware", "10002931" },
                    { 373, "Wheel Rim", "10006377" },
                    { 374, "Winch Parts/Components", "10002999" },
                    { 351, "Towing Mirrors (Automotive)", "10002970" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 375, "Winch/Winch Accessories Variety Packs", "10003001" },
                    { 350, "Towing Components – Heavy Duty", "10002974" },
                    { 348, "Safety Chains/Cables – Towing (Automotive)", "10002971" },
                    { 325, "Air Conditioning Refrigerants", "10005761" },
                    { 326, "Auto Repair Crawlers/Creepers", "10005720" },
                    { 327, "Glass Repair/Kits", "10002824" },
                    { 328, "Muffler/Exhaust Repair", "10002817" },
                    { 329, "Rear-view Mirror Repair/Kits", "10002822" },
                    { 330, "Window Defogger Repair/Kits", "10002823" },
                    { 331, "Carburettor/Choke Sprays", "10002779" },
                    { 332, "Carburettor/Parts Dip Cleaner", "10002780" },
                    { 333, "Electric Parts Cleaner (Automotive)", "10003775" },
                    { 334, "Engine Degreasers/Pollution Control", "10002781" },
                    { 335, "Automotive Fire Extinguishers", "10006904" },
                    { 336, "Emergency Fuel Aids", "10002826" },
                    { 337, "Mirrors (Automotive)", "10003774" },
                    { 338, "Protective Hose Bridges (Automotive)", "10005821" },
                    { 339, "Safety Replacement Parts/Accessories (Automotive)", "10003760" },
                    { 340, "Warning Flags/Flag Staffs (Automotive)", "10005820" },
                    { 341, "Fuel Injectors", "10006379" },
                    { 342, "Glow Plugs", "10006380" },
                    { 343, "Spark Plugs Other", "10003018" },
                    { 344, "Adaptors – Hitch (Automotive)", "10002962" },
                    { 345, "Hitch Covers (Automotive)", "10002968" },
                    { 346, "Hitch Steps (Automotive)", "10002969" },
                    { 347, "Pins/Clips – Hitch (Automotive)", "10002963" },
                    { 349, "Tow Hooks (Automotive)", "10002965" },
                    { 324, "Spot Lights (Automotive)", "10003759" },
                    { 376, "Washer Fluid (Automotive)", "10003764" },
                    { 378, "Wiper Blades", "10003011" },
                    { 406, "Skin Lightening", "10000486" },
                    { 407, "Tattoos/Stencils/Stick-on Jewellery – Temporary", "10000763" },
                    { 408, "Cosmetics/Fragrances Variety Packs", "10000672" },
                    { 409, "Fragrances", "10000365" },
                    { 410, "Cosmetics – Nails", "10000360" },
                    { 411, "Nail Cosmetic/Care Products – Replacement Parts", "10000768" },
                    { 412, "Nail Cosmetic/Care Products Variety Packs", "10000671" },
                    { 413, "Nails – Accessories (Non Powered)", "10000385" },
                    { 414, "Nails – Accessories (Powered)", "10000767" },
                    { 415, "Nails – Aids (Non Powered)", "10000358" },
                    { 416, "Nails – Aids (Powered)", "10000780" },
                    { 417, "Nails – Cleansers/Cosmetic Removers", "10000333" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 418, "Nails – False", "10000359" },
                    { 419, "Nails – Treatments", "10000361" },
                    { 420, "Hair – Accessories", "10000379" },
                    { 421, "Hair – Aids (Non Powered)", "10000564" },
                    { 422, "Hair – Aids (Powered)", "10000828" },
                    { 423, "Hair – Colour", "10000345" },
                    { 424, "Hair – Conditioner/Treatment", "10000346" },
                    { 425, "Hair – False", "10000343" },
                    { 426, "Hair – Perming", "10000348" },
                    { 427, "Hair – Shampoo", "10000368" },
                    { 428, "Hair – Styling (Non Powered)", "10000381" },
                    { 405, "Display Test (Cosmetics)", "10006201" },
                    { 377, "Wiper Arms (Automotive)", "10003142" },
                    { 404, "Cosmetics – Lips", "10000534" },
                    { 402, "Cosmetics – Complexion", "10000532" },
                    { 379, "Wiper Components Other", "10003150" },
                    { 380, "Wiper Cowls", "10003839" },
                    { 381, "Wiper Motors (Cores)", "10003145" },
                    { 382, "Wiper Pumps", "10003147" },
                    { 383, "Wipers/Wiper Parts Other", "10003013" },
                    { 384, "Cars/Vans/Sport Utility Vehicles/Light Trucks", "10006374" },
                    { 385, "All Terrain Vehicles (ATVs)", "10006772" },
                    { 386, "Motorcycles", "10006373" },
                    { 387, "Utility Task Vehicles (UTVs)/ Recreational Off-Road Vehicles (ROVs)", "10006773" },
                    { 388, "Beauty/Personal Care/Hygiene Variety Packs", "10000666" },
                    { 389, "Bath Massage/Toning", "10000807" },
                    { 390, "Body Massage/Toning – Replacement Parts", "10000758" },
                    { 391, "Body Massage/Toning Variety Packs", "10000668" },
                    { 392, "Body Toning/Firming Products (Powered)", "10000567" },
                    { 393, "Personal Warming/Massaging (Non Powered)", "10000566" },
                    { 394, "Personal Warming/Massaging (Powered)", "10000759" },
                    { 395, "Aromatherapy Cushions", "10000772" },
                    { 396, "Aromatherapy Variety Packs", "10000774" },
                    { 397, "Essential Oils", "10000771" },
                    { 398, "Oil Diffusers (Powered)", "10000770" },
                    { 399, "Cosmetic Aids/Accessories", "10000377" },
                    { 400, "Cosmetic Paints/Shimmers/Glitters", "10000761" },
                    { 401, "Cosmetic Products Variety Packs", "10000669" },
                    { 403, "Cosmetics – Eyes", "10000533" },
                    { 430, "Hair Care Products – Replacement Parts", "10000833" },
                    { 323, "Replacement Lenses (Automotive)", "10003045" },
                    { 321, "Lights/Bulbs Other (Automotive)", "10003047" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 244, "Cargo Management – Replacement Parts/Accessories", "10005130" },
                    { 245, "Cargo Management Other (Automotive)", "10002750" },
                    { 246, "Cargo Securing Equipment (Automotive)", "10002733" },
                    { 247, "Equipment Racks/Carriers (Automotive)", "10002734" },
                    { 248, "Extenders/Bumper Packs (Automotive)", "10002743" },
                    { 249, "Exterior Storage Carriers/Bags (Automotive)", "10005128" },
                    { 250, "Interior Storage Boxes/Trays/Baskets (Automotive)", "10002748" },
                    { 251, "Wheel Chocks (Automotive)", "10005818" },
                    { 252, "Decorative Lighting Other (Automotive)", "10003057" },
                    { 253, "Strobe Lighting (Automotive)", "10003055" },
                    { 254, "Automotive Electrical – Replacement Parts/Accessories", "10005131" },
                    { 255, "Automotive Instruments and Measurement Systems", "10006846" },
                    { 256, "Automotive Switches", "10005132" },
                    { 257, "Cigarette Lighters/Adaptors (Automotive)", "10003081" },
                    { 258, "Electrical Other (Automotive)", "10003084" },
                    { 259, "Flex Tube/Wire Loom (Automotive)", "10003080" },
                    { 260, "Horns/Sirens (Automotive)", "10003758" },
                    { 261, "Coverings/Protection Other (Automotive)", "10002909" },
                    { 262, "Lens Covers (Automotive)", "10002902" },
                    { 263, "License Plates – Decorative", "10002904" },
                    { 264, "Spare Tyre Covers", "10002905" },
                    { 265, "Tops/Skins – Replacement Parts/Accessories (Automotive)", "10002908" },
                    { 266, "Vehicle Covers", "10002900" },
                    { 243, "Other Parts for Brake Systems", "10006388" },
                    { 267, "Brush/Grill Guards", "10002888" },
                    { 242, "Brake Pads/Lining", "10006384" },
                    { 240, "Brake Disc Clip", "10006386" },
                    { 217, "Appearance Chemicals Other (Automotive)", "10002776" },
                    { 218, "Automotive Paint", "10006378" },
                    { 219, "Car Body Care – Washes/Waxes/Protectors/Removers", "10002767" },
                    { 220, "Car Interior Cleaning Kit", "10006375" },
                    { 221, "Car Tyre Care – Cleaners/Foams/Shines", "10002764" },
                    { 222, "Car Wheel Care – Cleaners/Shines", "10002773" },
                    { 223, "Car Windscreen Preparation (Automotive)", "10002757" },
                    { 224, "Air Fresheners – Non Powered (Automotive)", "10003753" },
                    { 225, "Air Fresheners – Powered (Automotive)", "10003752" },
                    { 226, "Appearance/Fragrance Accessories Other", "10002949" },
                    { 227, "Automotive Appearance/Fragrance – Accessories/Replacement Parts", "10005127" },
                    { 228, "Automotive Applicators/Brushes", "10005249" },
                    { 229, "Buffers/Polishing Machines (Automotive)", "10002944" },
                    { 230, "Ice Scrapers (Automotive)", "10003757" },
                    { 231, "Washing/Cleaning Systems – Powered (Automotive)", "10002940" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 232, "Batteries (Automotive)", "10005232" },
                    { 233, "Battery Accessories (Automotive)", "10005233" },
                    { 234, "Battery Booster", "10006383" },
                    { 235, "Automotive Body Repair Variety Packs", "10003834" },
                    { 236, "Body Repair Other (Automotive)", "10003761" },
                    { 237, "Reducers/Retarders (Automotive)", "10002723" },
                    { 238, "Scratch Fill/Plastic Repair Preparations (Automotive)", "10002720" },
                    { 239, "Brake Disc", "10006385" },
                    { 241, "Brake Drum/Brake Drum Parts", "10006389" },
                    { 322, "Reflectors (Automotive)", "10003046" },
                    { 268, "Decorative/Custom Grills", "10002890" },
                    { 270, "Extruded/Cast Steps (Automotive)", "10002886" },
                    { 298, "Headliners/Kits (Automotive)", "10002881" },
                    { 299, "Interior Accessories – Decorative Variety Packs (Automotive)", "10002882" },
                    { 300, "Pedal Covers/Sets (Automotive)", "10002877" },
                    { 301, "Shifter Knobs/Handles (Automotive)", "10002875" },
                    { 302, "Dash Trim Kits", "10002870" },
                    { 303, "Door Steps/Kick Plates (Automotive)", "10002866" },
                    { 304, "Floor Mats (Automotive)", "10002867" },
                    { 305, "Interior Cargo Liner/Trays (Automotive)", "10002868" },
                    { 306, "Replacement Carpet (Automotive)", "10002865" },
                    { 307, "Interior Storage Other (Automotive)", "10002846" },
                    { 308, "Tax Disc Holders (Automotive)", "10005122" },
                    { 309, "Baby Car/Booster Seats", "10000792" },
                    { 310, "Head/Neck Cushions (Automotive)", "10002842" },
                    { 311, "Seat Belts/Extenders", "10002840" },
                    { 312, "Seat Cushions (Automotive)", "10002839" },
                    { 313, "Seats (Automotive)", "10002837" },
                    { 314, "Steering Wheel Hardware/Accessories", "10002864" },
                    { 315, "Window Tints", "10002860" },
                    { 316, "Windshield Shades", "10002859" },
                    { 317, "Assemblies – Taillight", "10003050" },
                    { 318, "Back Up Lights (Automotive)", "10003037" },
                    { 319, "Driving Lights", "10003038" },
                    { 320, "Fog Lights (Automotive)", "10003036" },
                    { 297, "Decorative Accessory Knobs/Buttons", "10002878" },
                    { 269, "Push/A Bars (Automotive)", "10002889" },
                    { 296, "Thermometers (Automotive)", "10002855" },
                    { 294, "Key Holders (Automotive)", "10002852" },
                    { 271, "Running Boards (Automotive)", "10002884" },
                    { 272, "Cab Fairings", "10002898" },
                    { 273, "Rear Window Deflector/Roof Visors (Automotive)", "10002896" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 274, "Sunroof Deflectors", "10002897" },
                    { 275, "Emblems/Graphics – Decorative (Automotive)", "10002920" },
                    { 276, "Exterior Appearance Accessories Variety Packs", "10002923" },
                    { 277, "Light/Lens Mouldings (Automotive)", "10002919" },
                    { 278, "Scoops/Vents (Automotive)", "10002911" },
                    { 279, "Sunroofs/Moonroofs/T-tops (Automotive)", "10002910" },
                    { 280, "Air/Dust Filter Cleaner", "10006328" },
                    { 281, "Filter Accessories (Automotive)", "10003026" },
                    { 282, "Filters – Air (Automotive)", "10003022" },
                    { 283, "Filters – Fluid (Automotive)", "10003762" },
                    { 284, "Filters Other (Automotive)", "10003029" },
                    { 285, "Performance Filter Kits/Accessories (Automotive)", "10003028" },
                    { 286, "Fluid Change Items Other (Automotive)", "10003114" },
                    { 287, "Oil Mats (Automotive)", "10003113" },
                    { 288, "Filter Wrenches (Automotive)", "10003092" },
                    { 289, "Fluid Management/Accessories Other (Automotive)", "10003105" },
                    { 290, "Fluid Mixers (Automotive)", "10003099" },
                    { 291, "Clocks (Automotive)", "10002848" },
                    { 292, "Compasses (Automotive)", "10002850" },
                    { 293, "Fans (Automotive)", "10002857" },
                    { 295, "Refrigeration/Warmer Units (Automotive)", "10002858" },
                    { 861, "Fixed Communication Devices Accessories", "10005681" },
                    { 642, "Mouldings – Non Wood", "10003934" },
                    { 863, "Fixed Communication Pre-pay Vouchers/Calling Cards", "10001188" },
                    { 1430, "Quark Products (Frozen)", "10006756" },
                    { 1431, "Quark Products (Perishable)", "10006757" },
                    { 1432, "Quark Products (Shelf Stable)", "10006758" },
                    { 1433, "Yogurt/Yogurt Substitutes (Frozen)", "10000277" },
                    { 1434, "Yogurt/Yogurt Substitutes (Perishable)", "10000278" },
                    { 1435, "Yogurt/Yogurt Substitutes (Shelf Stable)", "10000279" },
                    { 1436, "Nuts/Seeds – Unprepared/Unprocessed (Perishable)", "10000007" },
                    { 1437, "Nuts/Seeds – Unprepared/Unprocessed (Shelf Stable)", "10000008" },
                    { 1438, "Fats Edible – Animal (Perishable)", "10000041" },
                    { 1439, "Fats Edible – Animal (Shelf Stable)", "10000574" },
                    { 1429, "Milk/Milk Substitutes (Shelf Stable)", "10000026" },
                    { 1440, "Fats Edible – Vegetable/Plant (Perishable)", "10000585" },
                    { 1442, "Fats Edible Variety Packs", "10000608" },
                    { 1443, "Oils Edible – Vegetable or Plant (Shelf Stable)", "10000040" },
                    { 1444, "Oils/Fats Edible Variety Packs", "10000609" },
                    { 1445, "Baby/Infant – Formula (Shelf Stable)", "10000575" },
                    { 1446, "Baby/Infant – Specialised Beverages (Shelf Stable)", "10000105" },
                    { 1447, "Baby/Infant – Specialised Foods (Frozen)", "10006273" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1448, "Baby/Infant – Specialised Foods (Shelf Stable)", "10000104" },
                    { 1449, "Dairy Based Products / Meals – Not Ready to Eat/Drink (Frozen)", "10005827" },
                    { 1450, "Dairy Based Products / Meals – Not Ready to Eat/Drink (Perishable)", "10005826" },
                    { 1451, "Dairy/Egg Based Products / Meals – Ready to Eat (Perishable)", "10005227" },
                    { 1441, "Fats Edible – Vegetable/Plant (Shelf Stable)", "10000042" },
                    { 1428, "Milk/Milk Substitutes (Perishable)", "10000025" },
                    { 1427, "Milk/Milk Substitutes (Frozen)", "10000027" },
                    { 1426, "Milk/Butter/Cream/Yogurts/Cheese/Eggs/Substitutes Variety Packs", "10000607" },
                    { 1403, "Chicken Sausages – Prepared/Processed", "10005834" },
                    { 1404, "Lamb/Mutton Sausages – Prepared/Processed", "10005835" },
                    { 1405, "Mixed Species Sausages – Prepared/Processed", "10005836" },
                    { 1406, "Pork Sausages – Prepared/Processed", "10005840" },
                    { 1407, "Turkey Sausages – Prepared/Processed", "10005837" },
                    { 1408, "Veal Sausages – Prepared/Processed", "10005838" },
                    { 1409, "Butter/Butter Substitutes (Frozen)", "10000167" },
                    { 1410, "Butter/Butter Substitutes (Perishable)", "10000168" },
                    { 1411, "Butter/Butter Substitutes (Shelf Stable)", "10000169" },
                    { 1412, "Cheese/Cheese Substitutes (Frozen)", "10000030" },
                    { 1413, "Cheese/Cheese Substitutes (Perishable)", "10000028" },
                    { 1414, "Cheese/Cheese Substitutes (Shelf Stable)", "10000029" },
                    { 1415, "Cream/Cream Substitutes (Frozen)", "10000188" },
                    { 1416, "Cream/Cream Substitutes (Perishable)", "10000189" },
                    { 1417, "Cream/Cream Substitutes (Shelf Stable)", "10000190" },
                    { 1418, "Dairy By-Products", "10006728" },
                    { 1419, "Eggs Extracts", "10006204" },
                    { 1420, "In-Shell Checked/Dirty Eggs", "10006203" },
                    { 1421, "In-Shell Nest Run Eggs", "10006202" },
                    { 1422, "Eggs Imitations", "10006213" },
                    { 1423, "Eggs Products/Substitutes", "10006212" },
                    { 1424, "In Shell Table Eggs", "10006210" },
                    { 1425, "Individually Cooked Eggs", "10006211" },
                    { 1452, "Dairy/Egg Based Products / Meals – Ready to Eat (Shelf Stable)", "10005228" },
                    { 1453, "Dairy/Egg Based Products / Meals Variety Packs", "10006229" },
                    { 1454, "Egg Based Products / Meals – Not Ready to Eat (Frozen)", "10005224" },
                    { 1455, "Egg Based Products / Meals – Not Ready to Eat (Perishable)", "10005225" },
                    { 1483, "Pasta/Noodles – Not Ready to Eat (Perishable)", "10000317" },
                    { 1484, "Pasta/Noodles – Not Ready to Eat (Shelf Stable)", "10000242" },
                    { 1485, "Pasta/Noodles – Ready to Eat (Perishable)", "10000240" },
                    { 1486, "Pasta/Noodles – Ready to Eat (Shelf Stable)", "10000241" },
                    { 1487, "Pasta/Noodles Variety Packs", "10006219" },
                    { 1488, "Soup Additions (Frozen)", "10006314" },
                    { 1489, "Soup Additions (Perishable)", "10006315" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1490, "Soup Additions (Shelf Stable)", "10006316" },
                    { 1491, "Soups – Prepared (Frozen)", "10000260" },
                    { 1492, "Soups – Prepared (Perishable)", "10000261" },
                    { 1493, "Soups – Prepared (Shelf Stable)", "10000262" },
                    { 1494, "Soups – Prepared Variety Packs", "10006216" },
                    { 1495, "Ready-Made Combination Meals – Not Ready to Eat (Frozen)", "10006748" },
                    { 1496, "Ready-Made Combination Meals – Not Ready to Eat (Perishable)", "10006749" },
                    { 1497, "Ready-Made Combination Meals – Not Ready to Eat (Shelf Stable)", "10006750" },
                    { 1498, "Ready-Made Combination Meals – Not Ready to Eat Variety Packs", "10006754" },
                    { 1499, "Ready-Made Combination Meals – Ready to Eat (Perishable)", "10006751" },
                    { 1500, "Ready-Made Combination Meals – Ready to Eat (Shelf Stable)", "10006752" },
                    { 1501, "Ready-Made Combination Meals – Ready to Eat Variety Packs", "10006753" },
                    { 1502, "Sandwiches/Filled Rolls/Wraps (Frozen)", "10000254" },
                    { 1503, "Sandwiches/Filled Rolls/Wraps (Perishable)", "10000255" },
                    { 1504, "Sandwiches/Filled Rolls/Wraps Variety Packs", "10006217" },
                    { 1505, "Caramel/Toffee Apples", "10005822" },
                    { 1482, "Pasta/Noodles – Not Ready to Eat (Frozen)", "10000318" },
                    { 1402, "Beef Sausages – Prepared/Processed", "10005833" },
                    { 1481, "Meat Substitutes Variety Packs", "10006230" },
                    { 1479, "Meat Substitutes (Perishable)", "10005824" },
                    { 1456, "Egg Based Products / Meals – Not Ready to Eat (Shelf Stable)", "10005226" },
                    { 1457, "Dessert Sauces/Toppings/Fillings (Frozen)", "10000193" },
                    { 1458, "Dessert Sauces/Toppings/Fillings (Perishable)", "10000194" },
                    { 1459, "Dessert Sauces/Toppings/Fillings (Shelf Stable)", "10000195" },
                    { 1460, "Desserts (Frozen)", "10000196" },
                    { 1461, "Desserts (Perishable)", "10000197" },
                    { 1462, "Desserts (Shelf Stable)", "10000312" },
                    { 1463, "Desserts/Dessert Toppings Variety Packs", "10000611" },
                    { 1464, "Ice Cream/Ice Novelties (Frozen)", "10000215" },
                    { 1465, "Ice Cream/Ice Novelties (Shelf Stable)", "10000216" },
                    { 1466, "Dough Based Products / Meals – Not Ready to Eat – Savoury (Frozen)", "10000301" },
                    { 1467, "Dough Based Products / Meals – Not Ready to Eat – Savoury (Perishable)", "10000300" },
                    { 1468, "Dough Based Products / Meals – Not Ready to Eat – Savoury (Shelf Stable)", "10000302" },
                    { 1469, "Dough Based Products / Meals – Ready to Eat – Savoury (Perishable)", "10000298" },
                    { 1470, "Dough Based Products / Meals – Ready to Eat – Savoury (Shelf Stable)", "10000299" },
                    { 1471, "Dough Based Products / Meals Variety Packs", "10006222" },
                    { 1472, "Grain Based Products / Meals – Not Ready to Eat – Savoury (Frozen)", "10000296" },
                    { 1473, "Grain Based Products / Meals – Not Ready to Eat – Savoury (Perishable)", "10000295" },
                    { 1474, "Grain Based Products / Meals – Not Ready to Eat – Savoury (Shelf Stable)", "10000297" },
                    { 1475, "Grain Based Products / Meals – Ready to Eat – Savoury (Perishable)", "10000293" },
                    { 1476, "Grain Based Products / Meals – Ready to Eat – Savoury (Shelf Stable)", "10000294" },
                    { 1477, "Grain Based Products / Meals Variety Packs", "10006228" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1478, "Meat Substitutes  (Frozen)", "10005823" },
                    { 1480, "Meat Substitutes (Shelf Stable)", "10005825" },
                    { 1401, "Alternative Meat/Poultry/Other Animal Sausages – Prepared/Processed", "10005832" },
                    { 1400, "Wild Boar – Unprepared/Unprocessed", "10006280" },
                    { 1399, "Water Buffalo – Unprepared/Unprocessed", "10006286" },
                    { 1322, "Purslane", "10006092" },
                    { 1323, "Rocket", "10006088" },
                    { 1324, "Sorrel", "10006090" },
                    { 1325, "Watercress", "10006048" },
                    { 1326, "Hin Choy", "10006420" },
                    { 1327, "New-Zealand Spinach", "10006427" },
                    { 1328, "Spinach", "10006091" },
                    { 1329, "Water Spinach /Ong Choy", "10006352" },
                    { 1330, "Celtuce", "10006761" },
                    { 1331, "Alternative Meat/Poultry/Other Animals Species – Prepared/Processed", "10005783" },
                    { 1332, "Antelope – Prepared/Processed", "10006298" },
                    { 1333, "Beef – Prepared/Processed", "10005767" },
                    { 1334, "Beefalo/Cattalo – Prepared/Processed", "10006299" },
                    { 1335, "Bison/Buffalo – Prepared/Processed", "10005768" },
                    { 1336, "Chicken – Prepared/Processed", "10005769" },
                    { 1337, "Deer, other than Roe Deer – Prepared/Processed", "10005770" },
                    { 1338, "Duck – Prepared/Processed", "10005771" },
                    { 1339, "Elk/Wapiti – Prepared/Processed", "10006300" },
                    { 1340, "Emu – Prepared/Processed", "10006304" },
                    { 1341, "Frog – Prepared/Processed", "10005772" },
                    { 1342, "Goat – Prepared/Processed", "10005773" },
                    { 1343, "Goose – Prepared/Processed", "10006305" },
                    { 1344, "Guinea Fowl – Prepared/Processed", "10006306" },
                    { 1321, "Lambs Lettuce", "10006086" },
                    { 1345, "Hare – Prepared/Processed", "10006297" },
                    { 1320, "Dandelion Greens/Lion's Tooth", "10006089" },
                    { 1318, "Oakleaf Lettuce", "10006426" },
                    { 1295, "Fruit/Nuts/Seeds Mixes – Prepared/Processed (Shelf Stable)", "10000207" },
                    { 1296, "Fruits/Vegetables/Nuts/Seeds Variety Packs", "10000605" },
                    { 1297, "Nuts/Seeds – Prepared/Processed (Perishable)", "10000235" },
                    { 1298, "Nuts/Seeds – Prepared/Processed (Shelf Stable)", "10000236" },
                    { 1299, "Vegetables – Prepared/Processed (Frozen)", "10000270" },
                    { 1300, "Vegetables – Prepared/Processed (Perishable)", "10000271" },
                    { 1301, "Vegetables – Prepared/Processed (Shelf Stable)", "10000272" },
                    { 1302, "Common Chicory", "10006422" },
                    { 1303, "Endive (Broad Leaf)", "10006155" },
                    { 1304, "Endive (Curled)", "10006097" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1305, "Puntarelle", "10006423" },
                    { 1306, "Radicchio (Redloof)", "10006421" },
                    { 1307, "Radicchio Rosso", "10006094" },
                    { 1308, "Sugarloaf", "10006095" },
                    { 1309, "Witloof (Belgian Endive)", "10006093" },
                    { 1310, "Batavia", "10006419" },
                    { 1311, "Head Lettuce (Butterhead)", "10006079" },
                    { 1312, "Iceberg Lettuce", "10006267" },
                    { 1313, "Romaine (Cos) Lettuce", "10006085" },
                    { 1314, "Leaf Vegetables – Unprepared/Unprocessed Variety Packs", "10006428" },
                    { 1315, "Lollo Bionda", "10006424" },
                    { 1316, "Lollo Rosso", "10006425" },
                    { 1317, "Loose Leaf/Multileaf Lettuce Other", "10006268" },
                    { 1319, "Baby Leaves", "10006269" },
                    { 1506, "Chips/Crisps/Snack Mixes – Natural/Extruded (Shelf Stable)", "10000177" },
                    { 1346, "Horse – Prepared/Processed", "10005774" },
                    { 1348, "Land Snail – Prepared/Processed", "10005776" },
                    { 1376, "Frog – Unprepared/Unprocessed", "10005791" },
                    { 1377, "Goat – Unprepared/Unprocessed", "10005792" },
                    { 1378, "Goose – Unprepared/Unprocessed", "10006289" },
                    { 1379, "Guinea Fowl – Unprepared/Unprocessed", "10006290" },
                    { 1380, "Hare – Unprepared/Unprocessed", "10006281" },
                    { 1381, "Horse – Unprepared/Unprocessed", "10005793" },
                    { 1382, "Lamb – Unprepared/Unprocessed", "10006278" },
                    { 1383, "Land Snail – Unprepared/Unprocessed", "10005795" },
                    { 1384, "Llama/Alpaca – Unprepared/Unprocessed", "10005796" },
                    { 1385, "Mixed Species Meat – Unprepared/Unprocessed", "10005797" },
                    { 1386, "Moose/Elk – Unprepared/Unprocessed", "10006285" },
                    { 1387, "Mutton – Unprepared/Unprocessed", "10006279" },
                    { 1388, "Ostrich – Unprepared/Unprocessed", "10005798" },
                    { 1389, "Pheasant – Unprepared/Unprocessed", "10005799" },
                    { 1390, "Pork – Unprepared/Unprocessed", "10005800" },
                    { 1391, "Quail – Unprepared/Unprocessed", "10006291" },
                    { 1392, "Rabbit – Unprepared/Unprocessed", "10005801" },
                    { 1393, "Reindeer/Caribou – Unprepared/Unprocessed", "10006287" },
                    { 1394, "Rhea – Unprepared/Unprocessed", "10006292" },
                    { 1395, "Roe Deer – Unprepared/Unprocessed", "10006394" },
                    { 1396, "Squab/Pigeon – Unprepared/Unprocessed", "10006293" },
                    { 1397, "Turkey – Unprepared/Unprocessed", "10005803" },
                    { 1398, "Veal – Unprepared/Unprocessed", "10005804" },
                    { 1375, "Emu – Unprepared/Unprocessed", "10006288" },
                    { 1347, "Lamb – Prepared/Processed", "10006294" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1374, "Elk/Wapiti – Unprepared/Unprocessed", "10006284" },
                    { 1372, "Deer, other than Roe Deer – Unprepared/Unprocessed", "10005789" },
                    { 1349, "Llama/Alpaca – Prepared/Processed", "10005777" },
                    { 1350, "Mixed Species Meat/Poultry/Other Animal - Alternative Meat – Prepared/Processed", "10005778" },
                    { 1351, "Moose/Elk – Prepared/Processed", "10006301" },
                    { 1352, "Mutton – Prepared/Processed", "10006295" },
                    { 1353, "Ostrich – Prepared/Processed", "10005779" },
                    { 1354, "Pheasant – Prepared/Processed", "10005780" },
                    { 1355, "Pork – Prepared/Processed", "10005781" },
                    { 1356, "Quail – Prepared/Processed", "10006307" },
                    { 1357, "Rabbit – Prepared/Processed", "10005782" },
                    { 1358, "Reindeer/Caribou – Prepared/Processed", "10006303" },
                    { 1359, "Rhea – Prepared/Processed", "10006308" },
                    { 1360, "Roe Deer – Prepared/Processed", "10006393" },
                    { 1361, "Squab/Pigeon – Prepared/Processed", "10006309" },
                    { 1362, "Turkey – Prepared/Processed", "10005784" },
                    { 1363, "Veal – Prepared/Processed", "10005785" },
                    { 1364, "Water Buffalo – Prepared/Processed", "10006302" },
                    { 1365, "Wild Boar – Prepared/Processed", "10006296" },
                    { 1366, "Alternative Meat/Poultry/Other Animal Species – Unprepared/Unprocessed", "10005802" },
                    { 1367, "Antelope – Unprepared/Unprocessed", "10006282" },
                    { 1368, "Beef – Unprepared/Unprocessed", "10005786" },
                    { 1369, "Beefalo/Cattalo – Unprepared/Unprocessed", "10006283" },
                    { 1370, "Bison/Buffalo – Unprepared/Unprocessed", "10005787" },
                    { 1371, "Chicken – Unprepared/Unprocessed", "10005788" },
                    { 1373, "Duck – Unprepared/Unprocessed", "10005790" },
                    { 1294, "Fruit/Nuts/Seeds Combination Variety Packs", "10000604" },
                    { 1507, "Doodles/ Puffs", "10006746" },
                    { 1509, "Salt Sticks / Mini Pretzels", "10006747" },
                    { 1645, "Kurrat", "10006007" },
                    { 1646, "Onions", "10006006" },
                    { 1647, "Shallots", "10006009" },
                    { 1648, "Spring (or Spanish) Onions", "10006005" },
                    { 1649, "Chickpeas", "10006271" },
                    { 1650, "Crooked Cucumber", "10006450" },
                    { 1651, "Cucumbers", "10006014" },
                    { 1652, "Gherkins", "10006449" },
                    { 1653, "Bitter Melon", "10006349" },
                    { 1654, "Courgettes", "10006015" },
                    { 1644, "Garlic", "10006003" },
                    { 1655, "Squash (Calabaza)", "10006355" },
                    { 1657, "Squash (Opo)", "10006357" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1658, "Gourds", "10006340" },
                    { 1659, "Pumpkins/Winter Squash", "10006038" },
                    { 1660, "Edible Flowers", "10006261" },
                    { 1661, "Ferns (Cinnamon)", "10006361" },
                    { 1662, "Ferns (Royal)", "10006362" },
                    { 1663, "Fiddlehead Ferns", "10006824" },
                    { 1664, "Beech Mushrooms", "10006263" },
                    { 1665, "Cep", "10006035" },
                    { 1666, "Chanterelles", "10006033" },
                    { 1656, "Squash (Choko)", "10006356" },
                    { 1643, "Elephant Garlic", "10006004" },
                    { 1642, "White Cabbages", "10005999" },
                    { 1641, "Turnips", "10006120" },
                    { 1618, "Bimi and Other Brassica Interbreeds", "10006445" },
                    { 1619, "Black Mustard", "10006341" },
                    { 1620, "Broccoli", "10005988" },
                    { 1621, "Brussel Sprouts", "10005996" },
                    { 1622, "Cauliflower", "10005987" },
                    { 1623, "Chinese Cabbages", "10006143" },
                    { 1624, "Choi Sum", "10006446" },
                    { 1625, "Gai Choy (Mustard Greens)", "10006339" },
                    { 1626, "Gai Lan", "10006823" },
                    { 1627, "Greens (Texas Mustard)", "10006342" },
                    { 1628, "Kale", "10006144" },
                    { 1629, "Kohlrabi", "10006146" },
                    { 1630, "May Turnips", "10006116" },
                    { 1631, "Mizuna", "10006444" },
                    { 1632, "Pak Choi", "10006145" },
                    { 1633, "Pointed Cabbage", "10006197" },
                    { 1634, "Red Cabbages", "10005997" },
                    { 1635, "Romanesco", "10006196" },
                    { 1636, "Savoy Cabbages", "10006000" },
                    { 1637, "Swedish Turnips (Rutabagas)", "10006118" },
                    { 1638, "Tatsoi", "10006447" },
                    { 1639, "Teltow Turnips", "10006119" },
                    { 1640, "Turnip Tops", "10006117" },
                    { 1667, "Common Cultivated Mushroom (Agaricus)", "10006157" },
                    { 1668, "Enokitake", "10006264" },
                    { 1669, "Eryngii", "10006265" },
                    { 1670, "Lingzhi Mushrooms", "10006836" },
                    { 1698, "Laurel", "10006058" },
                    { 1699, "Lemon Thyme", "10006076" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1700, "Lemon Verbena", "10006078" },
                    { 1701, "Lemongrass", "10006159" },
                    { 1702, "Lovage", "10006057" },
                    { 1703, "Marjoram", "10006059" },
                    { 1704, "Mugwort", "10006044" },
                    { 1705, "Oregano", "10006066" },
                    { 1706, "Peppermint", "10006062" },
                    { 1707, "Pot Marjoram", "10006060" },
                    { 1708, "Ramsons", "10006040" },
                    { 1709, "Rosemary", "10006072" },
                    { 1710, "Sage", "10006353" },
                    { 1711, "Spearmint", "10006064" },
                    { 1712, "Summer Savoury", "10006045" },
                    { 1713, "Sweet Cicely", "10006065" },
                    { 1714, "Tarragon", "10006051" },
                    { 1715, "Winter Savoury", "10006046" },
                    { 1716, "Armenian Cucumber", "10006830" },
                    { 1717, "Conomon Melons", "10006829" },
                    { 1718, "Melon (Horned)", "10006350" },
                    { 1719, "Netted Muskmelons", "10006828" },
                    { 1720, "Non-Netted Cantaloupe Melons", "10006826" },
                    { 1697, "Hyssop", "10006077" },
                    { 1617, "Yardlong Beans", "10006158" },
                    { 1696, "Holy Basil", "10006042" },
                    { 1694, "Garden Cress", "10006055" },
                    { 1671, "Morels", "10006032" },
                    { 1672, "Oyster Mushrooms", "10006031" },
                    { 1673, "Shiitake Mushrooms", "10006034" },
                    { 1674, "Truffles", "10006036" },
                    { 1675, "Wild Mushrooms (Other)", "10006266" },
                    { 1676, "American Basil", "10006043" },
                    { 1677, "Anise", "10006334" },
                    { 1678, "Apple Mint", "10006063" },
                    { 1679, "Archangel", "10006050" },
                    { 1680, "Balm", "10006061" },
                    { 1681, "Basil", "10006041" },
                    { 1682, "Borage", "10006047" },
                    { 1683, "Burnet Saxifrage", "10006071" },
                    { 1684, "Caraway", "10006056" },
                    { 1685, "Celery Leaves", "10006457" },
                    { 1686, "Chervil", "10006053" },
                    { 1687, "Chives", "10006074" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1688, "Common Thyme", "10006075" },
                    { 1689, "Coriander", "10006054" },
                    { 1690, "Curled Parsley", "10006198" },
                    { 1691, "Dill", "10006049" },
                    { 1692, "Fennel  (Subspecies dulce)", "10006052" },
                    { 1693, "Flat Parsley (Italian)", "10006199" },
                    { 1695, "Herbs Variety Pack", "10006456" },
                    { 1616, "Tamarindo", "10006359" },
                    { 1615, "Runner Beans", "10005979" },
                    { 1614, "Lima Beans", "10005982" },
                    { 1537, "Aquatic Plants Unprepared/Unprocessed (Frozen)", "10000138" },
                    { 1538, "Aquatic Plants Unprepared/Unprocessed (Perishable)", "10000137" },
                    { 1539, "Aquatic Plants Unprepared/Unprocessed (Shelf Stable)", "10000139" },
                    { 1540, "Fish – Prepared/Processed (Frozen)", "10000017" },
                    { 1541, "Fish – Prepared/Processed (Perishable)", "10000016" },
                    { 1542, "Fish – Prepared/Processed (Shelf Stable)", "10000018" },
                    { 1543, "Fish – Unprepared/Unprocessed (Frozen)", "10000281" },
                    { 1544, "Fish – Unprepared/Unprocessed (Perishable)", "10000282" },
                    { 1545, "Fish – Unprepared/Unprocessed (Shelf Stable)", "10000283" },
                    { 1546, "Seafood Variety Packs", "10000614" },
                    { 1547, "Shellfish Prepared/Processed (Frozen)", "10000256" },
                    { 1548, "Shellfish Prepared/Processed (Perishable)", "10000257" },
                    { 1549, "Shellfish Prepared/Processed (Shelf Stable)", "10000258" },
                    { 1550, "Shellfish – Unprepared/Unprocessed (Frozen)", "10000020" },
                    { 1551, "Shellfish – Unprepared/Unprocessed (Perishable)", "10000019" },
                    { 1552, "Shellfish – Unprepared/Unprocessed (Shelf Stable)", "10000021" },
                    { 1553, "Extracts/Salt/Meat Tenderisers (Shelf Stable)", "10000050" },
                    { 1554, "Extracts/Seasonings/Flavour Enhancers (Shelf Stable)", "10006214" },
                    { 1555, "Herbs/Spices (Frozen)", "10000212" },
                    { 1556, "Herbs/Spices (Perishable)", "10000048" },
                    { 1557, "Herbs/Spices (Shelf Stable)", "10000049" },
                    { 1558, "Herbs/Spices/Extracts Variety Packs", "10000615" },
                    { 1559, "Stock/Bones (Frozen)", "10000580" },
                    { 1536, "Aquatic Plants Prepared/Processed (Shelf Stable)", "10000153" },
                    { 1560, "Stock/Bones (Perishable)", "10000579" },
                    { 1535, "Aquatic Plants Prepared/Processed (Perishable)", "10000152" },
                    { 1533, "Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Unprepared/Unprocessed (Shelf Stable)", "10000631" },
                    { 1510, "Confectionery Based Spreads (Shelf Stable)", "10000187" },
                    { 862, "Fixed Communication Devices Variety Packs", "10001384" },
                    { 1512, "Honey Substitutes", "10006848" },
                    { 1513, "Jams/Marmalades (Shelf Stable)", "10000217" },
                    { 1514, "Jams/Marmalades/Fruit Spreads (Perishable)", "10006837" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1515, "Sweet Spreads Variety Packs", "10000621" },
                    { 1516, "Vegetable Based Products / Meals – Not Ready to Eat (Frozen)", "10000291" },
                    { 1517, "Vegetable Based Products / Meals – Not Ready to Eat (Perishable)", "10000290" },
                    { 1518, "Vegetable Based Products / Meals – Not Ready to Eat (Shelf Stable)", "10000292" },
                    { 1519, "Vegetable Based Products / Meals – Ready to Eat (Perishable)", "10000289" },
                    { 1520, "Vegetable Based Products / Meals – Ready to Eat (Shelf Stable)", "10000288" },
                    { 1521, "Vegetable Based Products / Meals Variety Packs", "10006221" },
                    { 1522, "Aquatic Invertebrates – Prepared/Processed (Frozen)", "10000145" },
                    { 1523, "Aquatic Invertebrates – Prepared/Processed (Perishable)", "10000146" },
                    { 1524, "Aquatic Invertebrates – Prepared/Processed (Shelf Stable)", "10000147" },
                    { 1525, "Aquatic Invertebrates – Unprepared/Unprocessed (Frozen)", "10000148" },
                    { 1526, "Aquatic Invertebrates – Unprepared/Unprocessed (Perishable)", "10000149" },
                    { 1527, "Aquatic Invertebrates – Unprepared/Unprocessed (Shelf Stable)", "10000150" },
                    { 1528, "Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Prepared/Processed (Frozen)", "10000626" },
                    { 1529, "Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Prepared/Processed (Perishable)", "10000627" },
                    { 1530, "Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Prepared/Processed (Shelf Stable)", "10000628" },
                    { 1531, "Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Unprepared/Unprocessed (Frozen)", "10000629" },
                    { 1532, "Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Unprepared/Unprocessed (Perishable)", "10000630" },
                    { 1534, "Aquatic Plants Prepared/Processed (Frozen)", "10000151" },
                    { 1508, "Popcorn (Shelf Stable)", "10000252" },
                    { 1561, "Stock/Bones (Shelf Stable)", "10000578" },
                    { 1563, "Chutneys/Relishes (Perishable)", "10000587" },
                    { 1591, "Tomato Ketchup/Ketchup Substitutes (Shelf Stable)", "10006325" },
                    { 1592, "Seasonings/Preservatives/Extracts Variety Packs", "10000619" },
                    { 1593, "Cooking Wines", "10000052" },
                    { 1594, "Vinegars", "10000051" },
                    { 1595, "Vinegars/Cooking Wines Variety Packs", "10000618" },
                    { 1596, "Cigarettes", "10000185" },
                    { 1597, "Cigars", "10000186" },
                    { 1598, "Electronic Cigarette Accessories", "10006730" },
                    { 1599, "Electronic Cigarettes", "10006729" },
                    { 1600, "Herbal Chew/Snuff – Non Tobacco", "10006313" },
                    { 1601, "Herbal Cigarettes – Non Tobacco", "10000584" },
                    { 1602, "Smoking Accessories", "10000303" },
                    { 1603, "Tobacco – Chewing/Snuff", "10000134" },
                    { 1604, "Tobacco – Loose", "10000267" },
                    { 1605, "Tobacco – Solid", "10000268" },
                    { 1606, "Tobacco Products/Smoking Accessories Variety Packs", "10000620" },
                    { 1607, "Vegetables – Unprepared/Unprocessed (Frozen)", "10000005" },
                    { 1608, "Vegetables – Unprepared/Unprocessed (Shelf Stable)", "10000006" },
                    { 1609, "Adzuki Beans", "10006834" },
                    { 1610, "Beans (Winged)", "10006336" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1611, "Broad Beans", "10005980" },
                    { 1612, "French/Wax Beans", "10005976" },
                    { 1613, "Jack Beans", "10005981" },
                    { 1590, "Tomato Ketchup/Ketchup Substitutes (Perishable)", "10006324" },
                    { 1562, "Chutneys/Relishes (Frozen)", "10000586" },
                    { 1589, "Tomato Ketchup/Ketchup Substitutes (Frozen)", "10006323" },
                    { 1587, "Sauces – Cooking (Shelf Stable)", "10000057" },
                    { 1564, "Chutneys/Relishes (Shelf Stable)", "10000180" },
                    { 1565, "Olives (Perishable)", "10000238" },
                    { 1566, "Olives (Shelf Stable)", "10000239" },
                    { 1567, "Pickled Vegetables", "10000244" },
                    { 1568, "Pickles/Relishes/Chutneys/Olives Variety Packs", "10000616" },
                    { 1569, "Dressing/Dips (Frozen)", "10000583" },
                    { 1570, "Dressings/Dips (Perishable)", "10000199" },
                    { 1571, "Dressings/Dips (Shelf Stable)", "10000200" },
                    { 1572, "Food Glazes (Shelf Stable)", "10000581" },
                    { 1573, "Mayonnaise/Mayonnaise Substitutes (Frozen)", "10006317" },
                    { 1574, "Mayonnaise/Mayonnaise Substitutes (Perishable)", "10006318" },
                    { 1575, "Mayonnaise/Mayonnaise Substitutes (Shelf Stable)", "10006319" },
                    { 1576, "Mustard (Frozen)", "10006320" },
                    { 1577, "Mustard (Perishable)", "10006321" },
                    { 1578, "Mustard (Shelf Stable)", "10006322" },
                    { 1579, "Other Sauces Dipping/Condiments/Savoury Toppings/Savoury Spreads/Marinades (Frozen)", "10000577" },
                    { 1580, "Other Sauces Dipping/Condiments/Savoury Toppings/Savoury Spreads/Marinades (Perishable)", "10000054" },
                    { 1581, "Other Sauces Dipping/Condiments/Savoury Toppings/Savoury Spreads/Marinades (Shelf Stable)", "10000280" },
                    { 1582, "Pate (Frozen)", "10000576" },
                    { 1583, "Pate (Perishable)", "10000064" },
                    { 1584, "Pate (Shelf Stable)", "10000306" },
                    { 1585, "Sauces – Cooking (Frozen)", "10000056" },
                    { 1586, "Sauces – Cooking (Perishable)", "10000055" },
                    { 1588, "Sauces/Spreads/Dips/Condiments Variety Packs", "10000617" },
                    { 1293, "Fruit – Prepared/Processed (Shelf Stable)", "10000206" },
                    { 1511, "Honey (Shelf Stable)", "10000213" },
                    { 1291, "Fruit – Prepared/Processed (Frozen)", "10000204" },
                    { 998, "Roselle hempplants (Hibiscus sabdariffa var. altissima)", "10006886" },
                    { 999, "Sea island cotton plants (Gossypium barbadense)", "10006883" },
                    { 1000, "Sisalplants (Agave sisalane)", "10006875" },
                    { 1001, "Agarwood trees (Aquilaria malaccensis)", "10006909" },
                    { 1002, "Balsam fir trees (Abies balsamea)", "10006911" },
                    { 1003, "Dyer's broom shrubs (Genista tinctoria)", "10006913" },
                    { 1004, "Henna trees (Lawsonia inermis)", "10006915" },
                    { 1005, "Kamala trees (Mallotus philippensis)", "10006917" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1006, "Madder plants (Rubia tinctorum)", "10006919" },
                    { 1007, "Olibanum trees (Boswelia)", "10006924" },
                    { 1008, "Senegal Rosewood trees (Pterocarpus erinaceus)", "10006922" },
                    { 1009, "Turpentine trees (Pistacia terebinthus)", "10006925" },
                    { 1010, "Cross Segment Variety Packs", "10000624" },
                    { 1011, "Cable Clips/Grommets/Ties", "10005651" },
                    { 1012, "Cable Markers", "10005648" },
                    { 1013, "Cable Marking Accessories", "10005674" },
                    { 1014, "Cable Reels/Pullers", "10005649" },
                    { 1015, "Cable/Wire Conduit/Ducting/Raceways", "10005647" },
                    { 1016, "Cabling/Wiring Protection/Wrapping", "10005650" },
                    { 1017, "Conduit Fittings", "10005660" },
                    { 1018, "Audio Visual Cables", "10005757" },
                    { 1019, "Computer Cables", "10005754" },
                    { 1020, "Satellite Installation Cables", "10005759" },
                    { 997, "Rattan palmtrees (Calamus rotang)", "10006879" },
                    { 1021, "Telecommunication Cables", "10005758" },
                    { 996, "Ramieplants (Boehmeria nivea)", "10006878" },
                    { 994, "Pita plants (Agave americana)", "10006869" },
                    { 971, "Plantain Banana shrubs (Musa x paradisiaca - AAB)", "10006936" },
                    { 972, "Snowbanana trees (Ensete glaucum)", "10006934" },
                    { 973, "Guayule plants (Parthenium argentatum)", "10006907" },
                    { 974, "Rubbertrees (Hevea brasiliensis)", "10006892" },
                    { 975, "Russian dandelion plants (Taraxacum kok-saghyz)", "10006908" },
                    { 976, "Aramina fiberplants (Musa textilis)", "10006888" },
                    { 977, "Bambooshrubs (Bambuseae)", "10006877" },
                    { 978, "China juteplants (Abutilon avicennae)", "10006868" },
                    { 979, "Congo Jute plants (Urena lobata)", "10006890" },
                    { 980, "Cottonplants (Gossypium hirsutum)", "10006884" },
                    { 981, "Flaxplants (Linum usitatissimum)", "10006887" },
                    { 982, "Hempplants (Cannabis sativa)", "10006880" },
                    { 983, "Henequen plants (Agave fourcroydes )", "10006872" },
                    { 984, "Indian flaxplants (Abroma augustum)", "10006867" },
                    { 985, "Ixtle or tampico plants (Agave lecheguilla)", "10006873" },
                    { 986, "Juteshrubs (Corchorus)", "10006882" },
                    { 987, "Kapoktrees (Ceiba pentandra)", "10006881" },
                    { 988, "Kenafplants (Hibiscus cannabinus)", "10006885" },
                    { 989, "Kyenkyen / Upastrees (Antiaris Africana)", "10006876" },
                    { 990, "Maguey plants (Agave cantala)", "10006870" },
                    { 991, "Mauritian hempplants (Furcraea foetida)", "10006871" },
                    { 992, "Nettleplants (Urtica dioica)", "10006891" },
                    { 993, "Other agave hemp plants (Agave letonae)", "10006874" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 995, "Raffia palmtrees (Raphia farinifera)", "10006889" },
                    { 970, "Lacatan banana shrubs (Musa acuminata × M. balbisiana - AA Group-  Lakatan)", "10006941" },
                    { 1022, "Electrical Wires", "10005541" },
                    { 1024, "Batteries/Chargers Variety Packs", "10000704" },
                    { 1053, "Dimmers", "10005634" },
                    { 1054, "Light Bulb Sockets", "10005633" },
                    { 1055, "Electrical Lighting - Other", "10006896" },
                    { 1056, "Electric Lanterns – Portable", "10005643" },
                    { 1057, "Electric Torches/Flashlights", "10005642" },
                    { 1058, "Extension Light – Portable", "10005669" },
                    { 1059, "Circuit Assemblies/Integrated Circuits", "10005661" },
                    { 1060, "Discreet Components", "10005662" },
                    { 1061, "Electronic Circuit Accessories", "10005667" },
                    { 1062, "Bonding/Grounding Braid", "10005546" },
                    { 1063, "Electronic Testers", "10005742" },
                    { 1064, "Extension/Power Supply Cords", "10005559" },
                    { 1065, "Multimeters", "10005599" },
                    { 1066, "Wall Plates (Electrical)", "10005505" },
                    { 1067, "Alcohol Making Kits", "10000142" },
                    { 1068, "Alcohol Making Supplies", "10000143" },
                    { 1069, "Alcoholic Beverages Variety Packs", "10000591" },
                    { 1070, "Alcoholic Cordials/Syrups", "10000589" },
                    { 1071, "Alcoholic Pre-mixed Drinks", "10000144" },
                    { 1072, "Apple/Pear Alcoholic Beverage – Sparkling", "10000181" },
                    { 1073, "Apple/Pear Alcoholic Beverage – Still", "10006327" },
                    { 1074, "Beer", "10000159" },
                    { 1075, "Liqueurs", "10000227" },
                    { 1052, "Ballasts/Starters", "10005481" },
                    { 1023, "Batteries", "10000546" },
                    { 1051, "Light Bulb Changers", "10005638" },
                    { 1049, "Lampshades", "10005635" },
                    { 1025, "Chargers", "10000548" },
                    { 1026, "Connectors (Electrical)", "10005573" },
                    { 1027, "Electrical Connection Variety Packs", "10005572" },
                    { 1028, "Plugs", "10000551" },
                    { 1029, "Sockets/Receptacles/Outlets", "10005567" },
                    { 1030, "Adaptors (Electrical)", "10005496" },
                    { 1031, "Busbars/Busways", "10005575" },
                    { 1032, "Capacitors", "10005622" },
                    { 1033, "Circuit Breakers", "10005576" },
                    { 1034, "Converters/Inverters/Regulators/Transformers", "10000547" },
                    { 1035, "Distribution Boards/Boxes", "10005583" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1036, "Electrical Distribution Accessories/Fittings", "10005577" },
                    { 1037, "Fuses", "10000549" },
                    { 1038, "Multi-use/Universal Electrical Timers/Controllers", "10005682" },
                    { 1040, "Splitters", "10005568" },
                    { 1041, "Surge Suppressors/Protectors", "10005585" },
                    { 1042, "Switches", "10005586" },
                    { 1043, "Terminal Blocks/Strips", "10005588" },
                    { 1044, "Lamps – Freestanding", "10005641" },
                    { 1045, "Light Bulbs/Tubes/Light-Emitting Diodes", "10000552" },
                    { 1046, "Lighting – Fixed", "10005639" },
                    { 1047, "Rope/String Lights", "10005644" },
                    { 1048, "Lamp Brackets/Fittings", "10005637" },
                    { 1050, "Lampstands/Bases", "10005636" },
                    { 1076, "Non Grape Fermented Alcoholic Beverages – Sparkling", "10003689" },
                    { 969, "Babybanana shrubs (Musa acuminata - AA)", "10006938" },
                    { 967, "Pawpaw trees (Asimina)", "10006933" },
                    { 890, "Computer Processors", "10001125" },
                    { 891, "Computer/Video Games Mass Storage", "10005683" },
                    { 892, "Expansion Boards/Cards", "10001126" },
                    { 893, "Computer Drives – Replacement Parts/Accessories", "10001129" },
                    { 894, "Computer Drives Variety Packs", "10001131" },
                    { 895, "Floppy Disc Drives", "10001132" },
                    { 896, "Hard Disc Drives", "10001133" },
                    { 897, "Optical Drives – Reading Only", "10001128" },
                    { 898, "Optical Drives – Reading/Writing", "10001127" },
                    { 899, "Swap Drives", "10001134" },
                    { 900, "Tape Drives/Streamers", "10001135" },
                    { 901, "Zip/Jaz Disk Drives", "10001136" },
                    { 902, "Computer Networking Equipment – Replacement Parts/Accessories", "10001172" },
                    { 903, "Computer Networking Equipment Variety Packs", "10001171" },
                    { 904, "Gateways", "10001163" },
                    { 905, "Modems", "10001164" },
                    { 906, "Network Access Points", "10001165" },
                    { 907, "Network Interface Cards", "10001167" },
                    { 908, "Network Routers", "10001168" },
                    { 909, "Network Switches", "10001169" },
                    { 910, "Network/USB Hubs", "10001166" },
                    { 911, "Repeaters", "10001173" },
                    { 912, "USB Internet Stick", "10005831" },
                    { 889, "Computer Motherboards", "10001123" },
                    { 913, "Card Readers", "10001115" },
                    { 888, "Computer Memory", "10001122" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 886, "Computer Components Variety Packs", "10001120" },
                    { 1292, "Fruit – Prepared/Processed (Perishable)", "10000205" },
                    { 864, "Intercoms", "10001189" },
                    { 865, "Telephone Switchboards", "10001190" },
                    { 866, "Telephones", "10001191" },
                    { 867, "Communication Radio Sets", "10001192" },
                    { 868, "GPS Equipment – Mobile Communications", "10001193" },
                    { 869, "GPS Software – Mobile Communications", "10001194" },
                    { 870, "Mobile Communication Devices/Services – Replacement Parts", "10003779" },
                    { 871, "Mobile Communication Devices/Services Other", "10001385" },
                    { 872, "Mobile Phone Pre-pay Vouchers/Cards", "10001195" },
                    { 873, "Mobile Phone SIM Cards/SIM Card Adapters", "10001196" },
                    { 874, "Mobile Phone Software", "10001197" },
                    { 875, "Mobile Phones/Smartphones", "10001198" },
                    { 876, "Pagers", "10001199" },
                    { 877, "Personal Digital Broadcasters/Trackers", "10005711" },
                    { 878, "Two-way Radios", "10001200" },
                    { 879, "Sign – Replacement Part/Accessory", "10006227" },
                    { 880, "Sign Holders", "10006226" },
                    { 881, "Signs, Combination", "10006225" },
                    { 882, "Signs, Preprinted", "10006223" },
                    { 883, "Signs, Unprinted", "10006224" },
                    { 884, "Computer Casing/Housing", "10001117" },
                    { 885, "Computer Components – Replacement Parts/Accessories", "10001118" },
                    { 887, "Computer Cooling", "10001121" },
                    { 968, "Sweetsop/Sugar apple trees (Annona squamosa)", "10006931" },
                    { 914, "Computer Casing/Housing Accessories", "10001116" },
                    { 916, "Computer Power Supplies", "10001124" },
                    { 944, "Scanners", "10001160" },
                    { 945, "Web-cameras", "10001161" },
                    { 946, "Computer Software (Non Games)", "10001138" },
                    { 947, "Computer Software (Non Games) –  Digital", "10006236" },
                    { 948, "Computer/Video Game Gaming Software", "10001137" },
                    { 949, "Computer/Video Game Gaming Software – Digital", "10006235" },
                    { 950, "Computer/Video Game Software Variety Packs", "10001140" },
                    { 951, "Computers Other", "10001142" },
                    { 952, "Electronic Organisers", "10001143" },
                    { 953, "Personal Computers  – Tablets/E-Book Readers", "10006276" },
                    { 954, "Personal Computers – All-in-One", "10006405" },
                    { 955, "Personal Computers – Desktop/Internet Terminal", "10001144" },
                    { 956, "Personal Computers – Portable", "10001145" },
                    { 957, "Personal Digital Assistants", "10001146" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 958, "Servers", "10001147" },
                    { 959, "Smart Watches", "10006743" },
                    { 960, "Computers/Video Games Variety Packs", "10001370" },
                    { 961, "Console Accessories", "10005763" },
                    { 962, "Video Game Consoles – Non Portable", "10003817" },
                    { 963, "Video Game Consoles – Portable", "10003818" },
                    { 964, "Video Game Consoles – Replacement Parts", "10003819" },
                    { 965, "Atemoya trees (Annona x atemoya)", "10006932" },
                    { 966, "Cherimoya trees (Annona cherimola)", "10006927" },
                    { 943, "Projection Systems", "10001159" },
                    { 915, "Computer Docking Ports/Cradles", "10001109" },
                    { 942, "Printers", "10001158" },
                    { 940, "Keyboard, Voice, Mouse (KVM) Switch", "10006745" },
                    { 917, "Computer Stands/Supports", "10005438" },
                    { 918, "Computer Tools/Tool Kits", "10001112" },
                    { 919, "Computer/Video Game Accessories Variety Packs", "10001363" },
                    { 920, "Computer/Video Game Cases/Carriers", "10001107" },
                    { 921, "Computer/Video Game Cleaning Products", "10001108" },
                    { 922, "Computer/Video Game Headsets", "10005741" },
                    { 923, "Computer/Video Game Security Products", "10001111" },
                    { 924, "Filters/Covers (Electronic Equipment)", "10001110" },
                    { 925, "Mats/Rests – Computing", "10001113" },
                    { 926, "Personal Data Assistant/Organiser Stylus", "10001114" },
                    { 927, "Personal Video Recorder", "10006744" },
                    { 928, "Video Editor", "10005843" },
                    { 929, "Computer Graphics Tablets", "10001149" },
                    { 930, "Computer Keyboards", "10001150" },
                    { 931, "Computer Pointing Devices", "10001151" },
                    { 932, "Computer/Video Game Control Devices", "10001148" },
                    { 933, "Computer/Video Game Control/Input Devices – Replacement Parts/Accessories", "10001152" },
                    { 934, "Computer/Video Game Control/Input Devices Variety Packs", "10001365" },
                    { 935, "Digital Pens", "10005686" },
                    { 936, "Computer Speakers/Mini Speakers", "10001154" },
                    { 937, "Computer/Video Game Monitors", "10001153" },
                    { 938, "Computer/Video Game Peripherals – Replacement Parts/Accessories", "10001155" },
                    { 939, "Computer/Video Game Peripherals Variety Packs", "10001367" },
                    { 941, "Printer Consumables", "10001156" },
                    { 1077, "Non Grape Fermented Alcoholic Beverages – Still", "10000588" },
                    { 1039, "Relays/Contactors", "10005570" },
                    { 1079, "Wine – Fortified", "10000273" },
                    { 1214, "Indian Limes", "10006438" },
                    { 1215, "King Mandarins", "10006439" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1216, "Kumquat", "10006345" },
                    { 1217, "Lemons", "10005882" },
                    { 1218, "Limequats", "10005885" },
                    { 1219, "Limes", "10005884" },
                    { 1220, "Mandarin Hybrids", "10006441" },
                    { 1221, "Mediterranean (Willowleaf) Mandarins", "10006440" },
                    { 1078, "Spirits", "10000263" },
                    { 1223, "Minneolas and other Tangelos", "10005880" },
                    { 1224, "Orangelos", "10006343" },
                    { 1225, "Oranges", "10005889" },
                    { 1226, "Pummelos", "10005877" },
                    { 1227, "Satsuma Mandarins", "10005887" },
                    { 1228, "Sweeties", "10005879" },
                    { 1229, "Tangerines", "10005888" },
                    { 1230, "Tangor", "10006442" },
                    { 1231, "Ugli", "10005881" },
                    { 1232, "Fruits – Unprepared/Unprocessed (Fresh) Variety Packs", "10006172" },
                    { 1233, "Kiwiberries", "10005938" },
                    { 1234, "Kiwifruits", "10005937" },
                    { 1235, "Bilimbi", "10005963" },
                    { 1236, "Breadfruits", "10005973" },
                    { 1213, "Honey Pomelos", "10005878" },
                    { 1237, "Cape Gooseberries", "10005965" },
                    { 1212, "Grapefruits", "10005876" },
                    { 1210, "Citron", "10006866" },
                    { 1187, "Acai Berries", "10006759" },
                    { 1188, "Bilberries", "10005928" },
                    { 1189, "Black Currants", "10006194" },
                    { 1190, "Blackberries", "10005923" },
                    { 1191, "Blueberries", "10005929" },
                    { 1192, "Boysenberries", "10005924" },
                    { 1193, "Cloudberries", "10005925" },
                    { 1194, "Cranberries", "10005930" },
                    { 1195, "Elderberries", "10006432" },
                    { 1196, "Five-Flavor Berries", "10006832" },
                    { 1197, "Goji Berries", "10006429" },
                    { 1198, "Gooseberries", "10005932" },
                    { 1199, "Hybrids of Berries", "10006430" },
                    { 1200, "Jostaberries", "10005934" },
                    { 1201, "Lingonberries", "10006431" },
                    { 1202, "Loganberries", "10006346" },
                    { 1203, "Madrona", "10006347" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1204, "Raspberries", "10005927" },
                    { 1205, "Red Currants", "10006193" },
                    { 1206, "Saskatoon Berries", "10006354" },
                    { 1207, "Strawberries", "10005921" },
                    { 1208, "Table Grapes", "10005918" },
                    { 1209, "Wood Strawberries", "10005922" },
                    { 1211, "Clementines", "10005886" },
                    { 1186, "Red Bananas", "10005899" },
                    { 1238, "Carambola", "10005961" },
                    { 1240, "Dates", "10005959" },
                    { 1268, "Crabapples", "10006338" },
                    { 1269, "Japanese Medlars", "10005901" },
                    { 1270, "Medlar", "10006414" },
                    { 1271, "Nashi", "10005902" },
                    { 1272, "Pears", "10005903" },
                    { 1273, "Quinces", "10006173" },
                    { 1274, "Ya Pear (Shandong)", "10006415" },
                    { 1275, "Apricots", "10005905" },
                    { 1276, "Damsons", "10005909" },
                    { 1277, "Greengages", "10005913" },
                    { 1278, "Japanese Plums", "10005914" },
                    { 1279, "Mirabelles", "10005910" },
                    { 1280, "Mumes", "10006831" },
                    { 1281, "Nectarines", "10005911" },
                    { 1282, "Paraguaya", "10006443" },
                    { 1283, "Peaches", "10005912" },
                    { 1284, "Plumcots", "10005915" },
                    { 1285, "Plums", "10005917" },
                    { 1286, "Sour Cherries", "10005907" },
                    { 1287, "Stemless/Sweet Cherries", "10005908" },
                    { 1288, "Stonefruit Hybrids", "10005916" },
                    { 1289, "Fruit – Unprepared/Unprocessed (Frozen)", "10000002" },
                    { 1290, "Fruit – Unprepared/Unprocessed (Shelf Stable)", "10000003" },
                    { 1267, "Apples", "10005900" },
                    { 1239, "Cassia", "10006437" },
                    { 1266, "Yellow Dragonfruits", "10005956" },
                    { 1264, "Pineapples", "10005935" },
                    { 1241, "Durian", "10005972" },
                    { 1242, "Feijoas", "10006160" },
                    { 1243, "Figs", "10005960" },
                    { 1244, "Guavas", "10005971" },
                    { 1245, "Jackfruits", "10005974" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1246, "Jambolan", "10006434" },
                    { 1247, "Longan (Dragons Eye)", "10006435" },
                    { 1248, "Lychees (Litchi)", "10005964" },
                    { 1249, "Mangos", "10005969" },
                    { 1250, "Mangosteen", "10005968" },
                    { 1251, "Pomegranates", "10005970" },
                    { 1252, "Prickly Pears (Barbary Figs)", "10005967" },
                    { 1253, "Rambutan", "10005966" },
                    { 1254, "Salak (Snake Fruit)", "10006436" },
                    { 1255, "Babacos", "10005955" },
                    { 1256, "Papayas Formosa", "10005954" },
                    { 1257, "Barbadines", "10005949" },
                    { 1258, "Curubas", "10005950" },
                    { 1259, "Purple Maracujas", "10005953" },
                    { 1260, "Sweet Granadilla", "10005951" },
                    { 1261, "Yellow Maracujas", "10005952" },
                    { 1262, "American Persimmon", "10005948" },
                    { 1263, "Kaki/ Sharon Fruits", "10005946" },
                    { 1265, "Sweet Pitayas", "10005957" },
                    { 1185, "Plantain Bananas", "10005898" },
                    { 1222, "Mexican Limes", "10005883" },
                    { 1183, "Baby Bananas", "10005896" },
                    { 1107, "Vegetable Juice Drinks – Not Ready to Drink (Shelf Stable)", "10006257" },
                    { 1108, "Chocolate/Cocoa/Malt – Ready to Drink", "10000179" },
                    { 1109, "Dairy/Dairy Substitute Based Drinks – Ready to Drink (Perishable)", "10000191" },
                    { 1110, "Dairy/Dairy Substitute Based Drinks – Ready to Drink (Shelf Stable)", "10000192" },
                    { 1111, "Drinks Flavoured – Ready to Drink", "10000201" },
                    { 1112, "Fruit Juice – Ready to Drink (Perishable)", "10000219" },
                    { 1113, "Fruit Juice – Ready to Drink (Shelf Stable)", "10000220" },
                    { 1114, "Fruit Juice Drinks – Ready to Drink (Perishable)", "10000222" },
                    { 1115, "Fruit Juice Drinks – Ready to Drink (Shelf Stable)", "10000223" },
                    { 1116, "Ice", "10000214" },
                    { 1106, "Vegetable Juice – Not Ready to Drink (Shelf Stable)", "10006254" },
                    { 1117, "Non Alcoholic Beverages Variety Packs – Ready to Drink", "10000594" },
                    { 1119, "Sports Drinks – Rehydration (Ready To Drink)", "10000265" },
                    { 1120, "Stimulants/Energy Drinks – Ready to Drink", "10000266" },
                    { 1121, "Vegetable Juice – Ready to Drink (Perishable)", "10006251" },
                    { 1122, "Vegetable Juice – Ready to Drink (Shelf Stable)", "10006252" },
                    { 1123, "Vegetable Juice Drinks – Ready to Drink (Perishable)", "10006255" },
                    { 1124, "Vegetable Juice Drinks – Ready to Drink (Shelf Stable)", "10006256" },
                    { 1125, "Baking/Cooking Mixes (Frozen)", "10000155" },
                    { 1126, "Baking/Cooking Mixes (Perishable)", "10000068" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1127, "Baking/Cooking Mixes (Shelf Stable)", "10000156" },
                    { 1128, "Baking/Cooking Mixes/Supplies Variety Packs", "10000595" },
                    { 1118, "Packaged Water", "10000232" },
                    { 1105, "Vegetable Juice – Not Ready to Drink (Frozen)", "10006253" },
                    { 1104, "Stimulants/Energy Drinks – Not Ready to Drink", "10000311" },
                    { 1103, "Sports Drinks – Rehydration (Not Ready to Drink)", "10000264" },
                    { 1080, "Wine – Sparkling", "10000275" },
                    { 1081, "Wine – Still", "10000276" },
                    { 1082, "Beverages Variety Packs", "10000623" },
                    { 1083, "Coffee – Beans/Ground", "10000111" },
                    { 1084, "Coffee – Instant", "10000115" },
                    { 1085, "Coffee – Ready to Drink", "10000114" },
                    { 1086, "Coffee Substitutes – Instant", "10006311" },
                    { 1087, "Coffee Substitutes – Ready to Drink", "10006312" },
                    { 1088, "Coffee Substitutes – Regular(Non-Instant)", "10006310" },
                    { 1089, "Coffee/Tea/Substitutes Variety Packs", "10000592" },
                    { 1090, "Fruit Herbal Infusions – Bags/Loose", "10000119" },
                    { 1091, "Fruit Herbal Infusions – Instant", "10000210" },
                    { 1092, "Fruit Herbal Infusions – Ready to Drink", "10000313" },
                    { 1184, "Bananas", "10005897" },
                    { 1094, "Tea – Instant", "10000117" },
                    { 1095, "Tea – Ready to Drink", "10000118" },
                    { 1096, "Chocolate/Cocoa/Malt – Not Ready to Drink", "10000178" },
                    { 1097, "Dairy/Dairy Substitute Based Drinks – Not Ready to Drink (Shelf Stable)", "10000310" },
                    { 1098, "Drinks Flavoured – Not Ready to Drink", "10000202" },
                    { 1099, "Fruit Juice – Not Ready to Drink (Frozen)", "10000307" },
                    { 1100, "Fruit Juice – Not Ready to Drink (Shelf Stable)", "10000308" },
                    { 1101, "Fruit Juice Drinks – Not Ready to Drink (Shelf Stable)", "10000309" },
                    { 1102, "Non Alcoholic Beverages Variety Packs – Not Ready to Drink", "10000593" },
                    { 1129, "Baking/Cooking Supplies (Frozen)", "10000157" },
                    { 1130, "Baking/Cooking Supplies (Perishable)", "10000069" },
                    { 1093, "Tea – Bags/Loose", "10000116" },
                    { 1132, "Biscuits/Cookies (Frozen)", "10000304" },
                    { 1160, "Cereal/Muesli Bars", "10000287" },
                    { 1161, "Cereals Products – Not Ready to Eat (Frozen)", "10006250" },
                    { 1162, "Cereals Products – Not Ready to Eat (Shelf Stable)", "10000285" },
                    { 1163, "Cereals Products – Ready to Eat (Shelf Stable)", "10000284" },
                    { 1164, "Processed Cereal Products Variety Packs", "10000600" },
                    { 1165, "Chewing Gum", "10006390" },
                    { 1166, "Chocolate and Chocolate/Sugar Candy Combinations – Confectionery", "10000045" },
                    { 1167, "Confectionery Products Variety Packs", "10000602" },
                    { 1168, "Sugar Candy/Sugar Candy Substitutes Confectionery", "10000047" }
                });

            migrationBuilder.InsertData(
                table: "BrickCategories",
                columns: new[] { "id", "brick", "brick_id" },
                values: new object[,]
                {
                    { 1169, "Confectionery/Sugar Sweetening Products Variety Packs", "10000622" },
                    { 1170, "Sugar/Sugar Substitutes (Shelf Stable)", "10000043" },
                    { 1171, "Sugars/Sugar Substitute Products Variety Packs", "10000603" },
                    { 1172, "Syrup/Treacle/Molasses (Shelf Stable)", "10000044" },
                    { 1173, "Food/Beverage/Tobacco Variety Packs", "10000590" },
                    { 1174, "Annona Other", "10006433" },
                    { 1176, "Cherimoya", "10005939" },
                    { 1177, "Soursop", "10005942" },
                    { 1178, "Sugar Apples", "10005940" },
                    { 1179, "Avocados – Pebbled Peel (Hass-Type)", "10006168" },
                    { 1180, "Avocados – Smooth Peel", "10006169" },
                    { 1181, "Finger Avocados", "10006167" },
                    { 1182, "Apple Bananas", "10005895" },
                    { 1131, "Baking/Cooking Supplies (Shelf Stable)", "10000158" },
                    { 1159, "Cereal Products – Ready to Eat (Perishable)", "10000286" },
                    { 1158, "Grains/Flour Variety Packs", "10000599" },
                    { 1175, "Bullock Hearts", "10005941" },
                    { 1156, "Grains/Cereal – Ready to Eat – (Perishable)", "10000316" },
                    { 1133, "Biscuits/Cookies (Perishable)", "10000160" },
                    { 1157, "Grains/Cereal – Ready to Eat – (Shelf Stable)", "10000319" },
                    { 1134, "Biscuits/Cookies (Shelf Stable)", "10000161" },
                    { 1135, "Biscuits/Cookies Variety Packs", "10000596" },
                    { 1136, "Dried Breads (Frozen)", "10000305" },
                    { 1138, "Bread (Frozen)", "10000163" },
                    { 1139, "Bread (Perishable)", "10000164" },
                    { 1140, "Bread (Shelf Stable)", "10000165" },
                    { 1141, "Bread/Bakery Products Variety Packs", "10000598" },
                    { 1142, "Pies/Pastries/Pizzas/Quiches – Savoury (Frozen)", "10000248" },
                    { 1143, "Pies/Pastries/Pizzas/Quiches – Savoury (Perishable)", "10000249" },
                    { 1144, "Pies/Pastries/Pizzas/Quiches – Savoury (Shelf Stable)", "10000250" },
                    { 1137, "Dried Breads (Shelf Stable)", "10000166" },
                    { 1146, "Cakes – Sweet (Perishable)", "10000171" },
                    { 1145, "Cakes – Sweet (Frozen)", "10000170" },
                    { 1152, "Flour – Cereal/Pulse (Shelf Stable)", "10000203" },
                    { 1153, "Grains/Cereal – Not Ready to Eat – (Frozen)", "10000314" },
                    { 1155, "Grains/Cereal – Not Ready to Eat – (Shelf Stable)", "10000211" },
                    { 1150, "Pies/Pastries – Sweet (Shelf Stable)", "10000247" },
                    { 1151, "Sweet Bakery Products Variety Packs", "10000597" },
                    { 1148, "Pies/Pastries – Sweet (Frozen)", "10000245" },
                    { 1147, "Cakes – Sweet (Shelf Stable)", "10000172" },
                    { 1149, "Pies/Pastries – Sweet (Perishable)", "10000246" },
                    { 1154, "Grains/Cereal – Not Ready to Eat – (Perishable)", "10000315" }
                });

            migrationBuilder.InsertData(
                table: "NetContents",
                columns: new[] { "id", "code", "description", "name" },
                values: new object[,]
                {
                    { 103, "L2", "Unit of measure expressed in litre per minute.", "litre per minute" },
                    { 104, "LBR", "A unit of measure defining the number of litres per day.", "Pound" },
                    { 102, "KWT", "", "kilowatt" },
                    { 105, "LD", "", "Litre per day" },
                    { 106, "LNE	", "The indication of the count of printed lines included on a paper communication (e.g. telegram) for invoicing purposes.", "Printed line count" },
                    { 107, "LUX", "Unit of measure of illumination (it corresponds to the illumination of a surface which normally and uniformly receives a light flow of 1 lumen per square meter).", "lux" },
                    { 108, "M4", "A unit of measure expressed as a monetary amount.", "Monetary value" },
                    { 111, "MC", "One millionth of a gram.", "microgram" },
                    { 110, "MAW", "", "megawatt" },
                    { 112, "MCU", "Unit of measure for radioactivity.", "millicurie" },
                    { 113, "MGM", "", "milligram" },
                    { 114, "MHZ", "", "megahertz" },
                    { 115, "MIN", "", "minute" },
                    { 101, "KWH", "", "kilowatt hour" },
                    { 116, "MMK", "A unit to measure a surface equal to one millionth of a quadrate", "square millimetre" },
                    { 117, "MMQ", "A unit of measure expressed in cubic milimetres.", "cubic millimetre" },
                    { 109, "MAL", "", "mega litre" },
                    { 100, "KVT", "", "kilovolt" },
                    { 89, "KB", "", "kilocharacter" },
                    { 98, "KTM", "", "kilometre" },
                    { 82, "HTZ", "One cycle per second.", "hertz" },
                    { 118, "MMT", "", "millimetre" },
                    { 83, "HUR", "A unit of measure expressed in square inch", "hour" },
                    { 84, "INH", "Inch (25,4 mm)", "inch" },
                    { 85, "INK", "", "Square inch" },
                    { 86, "JM", "", "Megajoule per cubic metre" },
                    { 87, "JOU", "", "joule" },
                    { 99, "KVA", "A unit of electric power.", "kilovolt - ampere" },
                    { 88, "K51", "", "Kilocalorie (mean)" },
                    { 91, "KEL", "", "kelvin" },
                    { 92, "KHZ", "", "kilohertz" },
                    { 93, "KJO", "", "kilojoule" },
                    { 94, "KL", "A measure of weight in terms of kilogram per metre.", "kilogram per metre" },
                    { 95, "KMH", "A unit of measure expressed in kilometre per hour.", "kilometre per hour" },
                    { 96, "KMQ", "A measure of weight in terms of kilogram per cubic metre.", "kilogram per cubic metre" },
                    { 97, "KPA", "Unit of measure expressed in kilopascal.", "kilopascal" },
                    { 90, "KBA", "", "kilobar" },
                    { 119, "MON", "The expression of a month as a measure unit.", "month" },
                    { 145, "RTO", "", "Ratio" },
                    { 121, "MQH", "A unit of measure defining the number of cubic metres per hour.", "Cubic metre per hour" },
                    { 143, "RJH", "A unit of force equal to 10 Newton.", "Decanewton" },
                    { 144, "RPM", "", "revolutions per minute" }
                });

            migrationBuilder.InsertData(
                table: "NetContents",
                columns: new[] { "id", "code", "description", "name" },
                values: new object[,]
                {
                    { 146, "SEC	", "", "second" },
                    { 147, "SMI", "A unit of measure expressed in mile", "Mile (statute mile)" },
                    { 148, "ST", "Metric ton (1000kg)", "sheet" },
                    { 149, "TNE", "A unit of count defining the number of tablets (tablet: a small flat or compressed solid object). Dosage form for pharmaceuticals, pressed or compacted from a powder into a solid dose.", "tonne (metric ton)" },
                    { 150, "U2", "", "tablet" },
                    { 142, "QTI", "Quart UK (1,1136523 dm3)", "quart (UK)" },
                    { 151, "UI", "A measure pertaining to a predefined activity.", "Unit of activity, predefined" },
                    { 153, "VLT", "", "volt" },
                    { 154, "WHR", "", "watt hour" },
                    { 155, "WTT", "", "watt" },
                    { 156, "YDK", "A unit of measure expressed in square yard", "Square yard" },
                    { 157, "YRD", "Yard (0,9144 m)", "yard" },
                    { 158, "ZP", "The indication of a page as a measurement unit for invoicing purposes, e.g. fax pages.", "page" },
                    { 81, "HMT", "A unit of linear measure equal to 10 E2 metres.", "hectometre" },
                    { 152, "VI", "Small glass container. E.g. for a liquid medicine or perfume.", "vial" },
                    { 141, "QAN", "", "quarter (of a year)" },
                    { 140, "PTN", "The identification of the number of portions (doses in medical terms) into which a complete product may be broken into for serving purposes, e.g. a pie with 6 portions, a liquid medicine with 20 doses.", "Portion " },
                    { 139, "PTI", "Pint UK (0,568262 dm3)", "pint (UK)" },
                    { 122, "MTK", "", "square metre" },
                    { 123, "MTQ", "", "cubic metre" },
                    { 124, "MTR", "", "metre" },
                    { 125, "MTS", "A unit of speed expressed in metres per second.", "Metre per second" },
                    { 126, "MWH", "", "megawatt hour (1000 kW.h)" },
                    { 127, "NAR", "", "number of articles" },
                    { 128, "NEW", "The SI unit of force, equal to the force that would give a mass of one kilogram an acceleration of one metre per second.", "newton" },
                    { 129, "NIU", "A unit of count defining the number of international units.", "number of international units" },
                    { 130, "NRL", "", "number of rolls" },
                    { 131, "ONZ", "Ounce GB, US (28,349523 g)", "ounce" },
                    { 132, "OZA", "Fluid ounce US (29,5735 cm3)", "fluid ounce (US)" },
                    { 133, "OZI", "Fluid ounce UK (28,413 cm3)", "fluid ounce (UK)" },
                    { 134, "P1", "This code is used to indicate measurements in terms of percentages, e.g. the relative humidity (code RA in data element 6313) is 52%.", "percent" },
                    { 135, "PA", "", "packet" },
                    { 136, "PAL", "The SI unit of pressure, equal to one Newton per square metre.", "pascal" },
                    { 137, "PF", "A number of articles expressed in terms of pallets.", "pallet (lift)" },
                    { 138, "PR", "Two articles which belong together but are not necessarily identical.", "pair" },
                    { 120, "MPA", "A unit of measure expressed in Megapascal.", "megapascal" },
                    { 80, "HLT", "", "hectolitre" },
                    { 6, "KGM", "", "kilogram" },
                    { 78, "GWH", "Gigawatt-hour (1 million kW/h)", "gigawatt hour" },
                    { 21, "A86", "Hertz multiplied by 10*9.", "gigahertz" },
                    { 22, "A99", "A unit of information equal to one binary digit.", "Bit" },
                    { 23, "ACR", "Acre (4840 yd2)", "acre" }
                });

            migrationBuilder.InsertData(
                table: "NetContents",
                columns: new[] { "id", "code", "description", "name" },
                values: new object[,]
                {
                    { 24, "AD", "A unit of information stored in a computer, equal to eight bits", "byte" },
                    { 25, "AMH", "Ampere-hour (3,6kC)", "ampere hour" },
                    { 26, "AMP", "", "ampere" },
                    { 27, "ANN", "The expression of a year as a measure unit.", "year" },
                    { 20, "A25", "", "cheval vapeur" },
                    { 28, "APZ", "", "Troy ounce or apothecary ounce" },
                    { 30, "ASU", "Alcoholic strength expressed by volume.", "alcoholic strength by volume" },
                    { 31, "AV", "Encaspuled dosage form for pharmaceuticals.", "capsule" },
                    { 32, "B13", "A unit of measure of heat energy expressed in joule per square metre.", "Joule per square metre" },
                    { 33, "B17", "A unit of count defining the number of entries made to the credit side of an account", "Credit" },
                    { 34, "BAR", "A unit of measure equal to 106 dines per square centimeter.", "bar" },
                    { 35, "BTU", "British thermal unit (1,055 kilojoules)", "British thermal unit" },
                    { 36, "C0", "Unit of measure for telephone calls. Code value is C0 (C Zero).", "call" },
                    { 29, "ASM", "Alcoholic strength expressed by mass.", "alcoholic strength by mass" },
                    { 37, "C60", "Unit of measure expressed in Ohm centimetre.", "ohm centimetre" },
                    { 19, "4P", "", "newton per metre" },
                    { 17, "4L", "A unit of computer memory equal to 1.048.576 (i.e. 2 power 20) bytes.", "megabyte" },
                    { 79, "H87", "A unit of count defining the number of pieces (piece: a single item, article or exemplar).", "Piece" },
                    { 1, "GRM", "", "gram" },
                    { 2, "LTR", "Litre (1 dm3)", "litre" },
                    { 3, "MLT", "", "millilitre" },
                    { 4, "CLT", "A unit of volume equal to one hundreth of a liter.", "centilitre" },
                    { 5, "CMT", "", "centimetre" },
                    { 7, "23", "g/cm3 as a unit of measure for the density of gas. This is necessary for dangerous substance articles for determination of the quantities that can be stored together on the shelf.", "gram per cubic centimetre" },
                    { 18, "4O", "One millionth of a farad. A farad is the capacitance of a capacitor between the plates of which a potential of 1 volt is created by a charge of 1 Coulomb.", "microfarad" },
                    { 8, "25", "A measure of weight in terms of gram per square centimetre.", "gram per square centimetre" },
                    { 10, "37", "", "ounce per square foot" },
                    { 11, "59", "", "part per million" },
                    { 12, "64", "A unit of measure expressed in pound per square inch", "Pound per square inch, gauge" },
                    { 13, "001", "", "Barrel (205 litres, 45 gallons) (GS1 Temporary Code)" },
                    { 14, "2N", "", "decibel" },
                    { 15, "2X", "A measure of speed in terms of metres per minute.", "metre per minute" },
                    { 16, "4K", "", "milliampere" },
                    { 9, "28", "Unit of measure expressed in kilogram per square metre.", "kilogram per square metre" },
                    { 39, "CDL", "Unit of measure of light intensity.", "candela" },
                    { 38, "C79", "A unit of accumulated energy of 1000 volt amperes over a period of one hour.", "Kilovolt Ampere Hour" },
                    { 60, "E31", "A unit of count defining the number of square metres per litre.", "Square metre per litre" },
                    { 61, "E32", "A unit of count defining the number of litres per hour.", "Litre per hour" },
                    { 62, "E34", "A unit of information equal to 10 E9 bytes.", "Gigabyte" },
                    { 63, "E37", "A unit of count defining the number of pixels (pixel: picture element).", "Pixel" },
                    { 64, "E38", "A unit of count equal to 10 E6 (1000000) pixels (picture elements).", "Megapixel" },
                    { 65, "E39", "A unit of information defining the number of dots per linear inch as a measure of the resolution or sharpness of an image.", "Dots per inch" }
                });

            migrationBuilder.InsertData(
                table: "NetContents",
                columns: new[] { "id", "code", "description", "name" },
                values: new object[,]
                {
                    { 66, "EA", "", "each" },
                    { 67, "EV", "A unit of measure pertaining to the number of envelopes.", "envelope" },
                    { 68, "FAH", "", "degree Fahrenheit" },
                    { 69, "FOT", "Foot (0,3048 m)", "foot" },
                    { 70, "FP", "A unit of measure expressed in pound per square foot", "Pound per square foot" },
                    { 71, "FTK", "A unit of measure expressed in square foot", "Square foot" },
                    { 72, "FTQ", "", "cubic foot" },
                    { 73, "GL", "", "gram per litre" },
                    { 74, "GLI", "Gallon (4,546092 dm3)", "gallon (UK)" },
                    { 75, "GM", "Unit of measure of grams per square metre.", "gram per square metre" },
                    { 40, "CEL", "", "degree celsius" },
                    { 59, "E27", "A unit of count defining the number of doses (dose: a definite quantity of a medicine or drug).", "Dose" },
                    { 58, "E11", "A unit of heat energy equal to one thousand million calories.", "Gigacalorie" },
                    { 57, "E10", "A unit of measure used in meteorology and engineering to measure the demand for heating or cooling over a given period of days.", "Degree day" },
                    { 41, "CF2", "Colony forming units per gram is a unit of measure for micro-organisms, such as bacteria, in a food item. Micro-organisms form colonies that are be counted under determined conditions", "Colony forming unit per gram " },
                    { 42, "CMK", "", "square centimetre" },
                    { 43, "CMQ", "A system of units for the measurement of volume based on the cubic centimetre.", "cubic centimetre" },
                    { 44, "D19", "Unit of measure of thermal insulance expressed in square metre kelvin per watt.", "Square metre kelvin per watt" },
                    { 45, "D21", "Unit of measure expressed in square metre per kilogram.", "square metre per kilogram" },
                    { 46, "D32", "A unit of measure expressed in terawatt hour", "Terawatt hour" },
                    { 47, "D5", "A unit of measure expressed in kilogram per square centimetre", "Kilogram per square centimetre" },
                    { 76, "GRO", "A unit of measure of 12 dozens.", "gross" },
                    { 48, "D55", "Unit of measure of thermal conductance expressed in watt per square metre kelvin.", "Watt per square metre kelvin" },
                    { 50, "DAY", "The expression of a day as a measure unit", "day" },
                    { 51, "DD", "Unit of measure of temperature.", "degree" },
                    { 52, "DMQ", "Unit of measure expressed in cubic decimetre.", "cubic decimetre" },
                    { 53, "DMT", "", "decimetre" },
                    { 54, "DRG", "Number of dragées (coated tablets) contained in the item's package as a measurement unit.", "Dragée" },
                    { 55, "DZN", "A unit of measure of 12 or group of 12.", "dozen" },
                    { 56, "E09", "A unit of power load delivered at the rate of one thousandth of an ampere over a period of one hour.", "Milliampere hour" },
                    { 49, "D68", "A unit of count defining the number of words.", "Number of Words" },
                    { 77, "GV", "", "gigajoule" }
                });

            migrationBuilder.InsertData(
                table: "PackageLevels",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 5, "A shipping unit that contains either cases, inner packs, or eaches. It must contain one GTIN regardless of the number of items in the grouping.", "Pallet" },
                    { 6, "A shipping unit that can contain any combination of cases, inner packs, and/or eaches and must contain more than one GTIN.", "Mixed Pallet" },
                    { 4, "Contains more than one type of each, and must contain more than one GTIN. The case can contain eaches or inner packs.", "Mixed Case" },
                    { 7, "", "Case as Each" },
                    { 2, "Each units may be packed into inner packs, which are then packed into a case. Most items do not have an inner pack", "Inner Pack" },
                    { 1, "The lowest level of the item hierarchy intended or labeled for individual resale. Generally this is the consumer unit sold at check out or online.", "Each" },
                    { 3, "A standard shipping unit that contains eaches (packaged either individually or grouped as an inner pack). All of the items in a case must have the same GTIN.", "Case" }
                });

            migrationBuilder.InsertData(
                table: "PackagingTypes",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 25, "Glass" },
                    { 24, "Jar" },
                    { 23, "Rack" }
                });

            migrationBuilder.InsertData(
                table: "PackagingTypes",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 22, "Plastic bag" },
                    { 21, "Paper bag" },
                    { 20, "Tube" },
                    { 19, "Tablet" },
                    { 17, "Roll" },
                    { 16, "Tray" },
                    { 15, "net" },
                    { 14, "Multipack" },
                    { 13, "Foil" },
                    { 18, "Shrinkwrap" },
                    { 11, "Cup" },
                    { 12, "Envelope" },
                    { 1, "Aerosol" },
                    { 2, "Bag" },
                    { 3, "Basket" },
                    { 5, "Bottle" },
                    { 4, "Barrel" },
                    { 7, "Box" },
                    { 8, "Cage" },
                    { 9, "Can" },
                    { 10, "Cardboard carrier" },
                    { 6, "Bucket" }
                });

            migrationBuilder.InsertData(
                table: "TargetMarkets",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 580, "Northern Mariana Islands" },
                    { 548, "Vanuatu" },
                    { 583, "Micronesia, Federated States of" },
                    { 581, "United States Minor Outlying Islands" },
                    { 578, "Norway" },
                    { 554, "New Zealand" },
                    { 570, "Niue" },
                    { 566, "Nigeria" },
                    { 562, "Niger" },
                    { 558, "Nicaragua" },
                    { 584, "Marshall Islands" },
                    { 574, "Norfolk Island" },
                    { 585, "Palau" },
                    { 630, "Puerto Rico" },
                    { 591, "Panama" },
                    { 598, "Papua New Guinea" },
                    { 600, "Paraguay" },
                    { 604, "Peru" },
                    { 608, "Philippines" },
                    { 434, "Libyan Arab Jamahiriya" }
                });

            migrationBuilder.InsertData(
                table: "TargetMarkets",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 612, "Pitcairn" },
                    { 616, "Poland" },
                    { 620, "Portugal" },
                    { 624, "Guinea-Bissau" },
                    { 626, "Timor-Leste" },
                    { 540, "New Caledonia" },
                    { 634, "Qatar" },
                    { 586, "Pakistan" },
                    { 535, "Bonaire, Saint Eustatius, SABA" },
                    { 496, "Mongolia" },
                    { 533, "Aruba" },
                    { 638, "Réunion" },
                    { 438, "Liechtenstein" },
                    { 440, "Lithuania" },
                    { 442, "Luxembourg" },
                    { 446, "Macao" },
                    { 450, "Madagascar" },
                    { 454, "Malawi" },
                    { 458, "Malaysia" },
                    { 462, "Maldives" },
                    { 466, "Mali" },
                    { 470, "Malta" },
                    { 474, "Martinique" },
                    { 478, "Mauritania" },
                    { 480, "Mauritius" },
                    { 484, "Mexico" },
                    { 492, "Monaco" },
                    { 498, "Moldova, Republic of" },
                    { 499, "Montenegro" },
                    { 500, "Montserrat" },
                    { 504, "Morocco" },
                    { 508, "Mozambique" },
                    { 512, "Oman" },
                    { 516, "Namibia" },
                    { 520, "Nauru" },
                    { 524, "Nepal" },
                    { 528, "Netherlands" },
                    { 531, "Curacao" },
                    { 534, "Sint-Maarten (Dutch part)" },
                    { 642, "Romania" },
                    { 840, "United States" },
                    { 646, "Rwanda" }
                });

            migrationBuilder.InsertData(
                table: "TargetMarkets",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 764, "Thailand" },
                    { 768, "Togo" },
                    { 772, "Tokelau" },
                    { 776, "Tonga" },
                    { 780, "Trinidad and Tobago" },
                    { 784, "United Arab Emirates" },
                    { 788, "Tunisia" },
                    { 792, "Turkey" },
                    { 795, "Turkmenistan" },
                    { 796, "Turks and Caicos Islands" },
                    { 798, "Tuvalu" },
                    { 800, "Uganda" },
                    { 804, "Ukraine" },
                    { 762, "Tajikistan" },
                    { 807, "North Macedonia" },
                    { 826, "United Kingdom" },
                    { 831, "Guernsey" },
                    { 832, "Jersey" },
                    { 833, "Isle of Man" },
                    { 834, "Tanzania, United Republic of" },
                    { 430, "Liberia" },
                    { 850, "Virgin Islands, U.S." },
                    { 854, "Burkina Faso" },
                    { 858, "Uruguay" },
                    { 860, "Uzbekistan" },
                    { 862, "Venezuela, Bolivarian Republic of" },
                    { 876, "Wallis and Futuna" },
                    { 882, "Samoa" },
                    { 818, "Egypt" },
                    { 643, "Russian Federation" },
                    { 760, "Syrian Arab Republic" },
                    { 752, "Sweden" },
                    { 652, "Saint Barthélemy" },
                    { 654, "Saint Helena" },
                    { 659, "Saint Kitts and Nevis" },
                    { 660, "Anguilla" },
                    { 662, "Saint Lucia" },
                    { 663, "Saint Martin (French part)" },
                    { 666, "Saint Pierre and Miquelon" },
                    { 670, "Saint Vincent and the Grenadines" },
                    { 674, "San Marino" },
                    { 678, "Sao Tome and Principe" }
                });

            migrationBuilder.InsertData(
                table: "TargetMarkets",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 682, "Saudi Arabia" },
                    { 686, "Senegal" },
                    { 688, "Serbia" },
                    { 756, "Switzerland" },
                    { 690, "Seychelles" },
                    { 702, "Singapore" },
                    { 703, "Slovakia" },
                    { 704, "Viet Nam" },
                    { 705, "Slovenia" },
                    { 706, "Somalia" },
                    { 710, "South Africa" },
                    { 716, "Zimbabwe" },
                    { 724, "Spain" },
                    { 732, "Western Sahara" },
                    { 736, "Sudan" },
                    { 740, "Suriname" },
                    { 744, "Svalbard and Jan Mayen" },
                    { 748, "Swaziland" },
                    { 694, "Sierra Leone" },
                    { 428, "Latvia" },
                    { 234, "Faroe Islands" },
                    { 422, "Lebanon" },
                    { 97, "European Union" },
                    { 100, "Bulgaria" },
                    { 104, "Myanmar" },
                    { 108, "Burundi" },
                    { 112, "Belarus" },
                    { 116, "Cambodia" },
                    { 120, "Cameroon" },
                    { 124, "Canada" },
                    { 132, "Cape Verde" },
                    { 136, "Cayman Islands" },
                    { 140, "Central African Republic" },
                    { 144, "Sri Lanka" },
                    { 148, "Chad" },
                    { 152, "Chile" },
                    { 156, "China" },
                    { 158, "Taiwan, Province of China" },
                    { 162, "Christmas Island" },
                    { 166, "Cocos (Keeling) Islands" },
                    { 170, "Colombia" },
                    { 174, "Comoros" }
                });

            migrationBuilder.InsertData(
                table: "TargetMarkets",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 175, "Mayotte" },
                    { 178, "Congo" },
                    { 184, "Cook Islands" },
                    { 180, "Congo, the Democratic Republic of the" },
                    { 188, "Costa Rica" },
                    { 191, "Croatia" },
                    { 192, "Cuba" },
                    { 96, "Brunei Darussalam" },
                    { 92, "Virgin Islands, British" },
                    { 90, "Solomon Islands" },
                    { 86, "British Indian Ocean Territory" },
                    { 887, "Yemen" },
                    { 1, "Global Market" },
                    { 4, "Afghanistan" },
                    { 8, "Albania" },
                    { 10, "Antarctica" },
                    { 12, "Algeria" },
                    { 16, "American Samoa" },
                    { 20, "Andorra" },
                    { 24, "Angola" },
                    { 28, "Antigua and Barbuda" },
                    { 31, "Azerbaijan" },
                    { 32, "Argentina" },
                    { 36, "Australia" },
                    { 196, "Cyprus" },
                    { 40, "Austria" },
                    { 48, "Bahrain" },
                    { 50, "Bangladesh" },
                    { 51, "Armenia" },
                    { 52, "Barbados" },
                    { 56, "Belgium" },
                    { 60, "Bermuda" },
                    { 64, "Bhutan" },
                    { 68, "Bolivia, Plurinational State of" },
                    { 70, "Bosnia and Herzegovina" },
                    { 72, "Botswana" },
                    { 74, "Bouvet Island" },
                    { 76, "Brazil" },
                    { 84, "Belize" },
                    { 44, "Bahamas" },
                    { 203, "Czech Republic" },
                    { 204, "Benin" }
                });

            migrationBuilder.InsertData(
                table: "TargetMarkets",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 208, "Denmark" },
                    { 320, "Guatemala" },
                    { 324, "Guinea" },
                    { 328, "Guyana" },
                    { 332, "Haiti" },
                    { 334, "Heard Island and McDonald Islands" },
                    { 336, "Holy See (Vatican City State)" },
                    { 340, "Honduras" },
                    { 344, "Hong Kong" },
                    { 348, "Hungary" },
                    { 352, "Iceland" },
                    { 356, "India" },
                    { 360, "Indonesia" },
                    { 364, "Iran, Islamic Republic of" },
                    { 316, "Guam" },
                    { 368, "Iraq" },
                    { 376, "Israel" },
                    { 380, "Italy" },
                    { 384, "Côte d'Ivoire" },
                    { 388, "Jamaica" },
                    { 392, "Japan" },
                    { 398, "Kazakhstan" },
                    { 400, "Jordan" },
                    { 404, "Kenya" },
                    { 408, "Korea, Democratic People's Republic of" },
                    { 410, "Korea, Republic of" },
                    { 414, "Kuwait" },
                    { 417, "Kyrgyzstan" },
                    { 418, "Lao People's Democratic Republic" },
                    { 372, "Ireland" },
                    { 426, "Lesotho" },
                    { 312, "Guadeloupe" },
                    { 304, "Greenland" },
                    { 231, "Ethiopia" },
                    { 212, "Dominica" },
                    { 214, "Dominican Republic" },
                    { 218, "Ecuador" },
                    { 222, "El Salvador" },
                    { 226, "Equatorial Guinea" },
                    { 232, "Eritrea" },
                    { 233, "Estonia" },
                    { 238, "Falkland Islands (Malvinas)" }
                });

            migrationBuilder.InsertData(
                table: "TargetMarkets",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 239, "South Georgia and the South Sandwich Islands" },
                    { 242, "Fiji" },
                    { 246, "Finland" },
                    { 249, "Metropolitan France" },
                    { 308, "Grenada" },
                    { 248, "Åland Islands" },
                    { 254, "French Guiana" },
                    { 258, "French Polynesia" },
                    { 260, "French Southern Territories" },
                    { 262, "Djibouti" },
                    { 266, "Gabon" },
                    { 268, "Georgia" },
                    { 270, "Gambia" },
                    { 275, "Occupied Palestinian Territory" },
                    { 276, "Germany" },
                    { 288, "Ghana" },
                    { 292, "Gibraltar" },
                    { 296, "Kiribati" },
                    { 300, "Greece" },
                    { 250, "France" },
                    { 894, "Zambia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1897);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1899);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1911);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1912);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1913);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1914);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1915);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1916);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1917);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1918);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1919);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1920);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1921);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1922);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1923);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1924);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1926);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1928);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1931);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1932);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1933);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1934);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1935);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1936);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1937);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1938);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1939);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1940);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1941);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1942);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1943);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1944);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1945);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1946);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1948);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1949);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1950);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1952);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1953);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1956);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1957);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1958);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1959);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1961);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1962);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1963);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1964);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1965);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1969);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1970);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1971);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1972);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1973);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1975);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1976);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1977);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1978);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1979);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1980);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1981);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1982);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1983);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1984);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1985);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1986);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1987);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1988);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1989);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1990);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1991);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1994);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1995);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1996);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1998);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 1999);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2075);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2088);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2115);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2116);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2119);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2121);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2123);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2124);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2125);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2127);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2129);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2130);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2131);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2132);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2133);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2134);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2136);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2137);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2141);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2142);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2143);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2144);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2145);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2146);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2147);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2148);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2149);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2150);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2151);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2152);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2153);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2154);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2155);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2156);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2157);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2158);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2159);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2160);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2161);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2162);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2163);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2164);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2165);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2166);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2167);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2168);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2169);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2170);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2171);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2172);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2173);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2174);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2175);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2176);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2177);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2178);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2179);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2180);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2181);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2182);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2183);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2184);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2185);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2186);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2187);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2188);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2189);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2190);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2191);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2192);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2193);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2194);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2195);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2196);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2197);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2198);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2199);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2200);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2201);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2202);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2203);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2204);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2205);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2206);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2207);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2208);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2209);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2210);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2211);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2212);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2213);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2214);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2215);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2216);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2217);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2218);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2219);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2220);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2221);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2222);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2223);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2224);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2225);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2226);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2227);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2228);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2229);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2230);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2231);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2232);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2233);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2234);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2235);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2236);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2237);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2238);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2239);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2240);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2241);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2242);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2243);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2244);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2245);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2246);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2247);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2248);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2249);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2250);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2251);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2252);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2253);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2254);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2255);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2256);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2257);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2258);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2259);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2260);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2261);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2262);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2263);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2264);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2265);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2266);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2267);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2268);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2269);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2270);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2271);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2272);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2273);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2274);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2275);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2276);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2277);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2278);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2279);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2280);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2281);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2282);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2283);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2284);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2285);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2286);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2287);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2288);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2289);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2290);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2291);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2292);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2293);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2294);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2295);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2296);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2297);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2298);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2299);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2300);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2301);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2302);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2303);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2304);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2305);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2306);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2307);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2308);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2309);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2310);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2311);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2312);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2313);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2314);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2315);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2316);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2317);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2318);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2319);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2320);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2321);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2322);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2323);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2324);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2325);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2326);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2327);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2328);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2329);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2330);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2331);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2332);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2333);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2334);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2335);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2336);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2337);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2338);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2339);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2340);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2341);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2342);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2343);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2344);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2345);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2346);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2347);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2348);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2349);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2350);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2351);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2352);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2353);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2354);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2355);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2356);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2357);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2358);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2359);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2360);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2361);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2362);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2363);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2364);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2365);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2366);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2367);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2368);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2369);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2370);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2371);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2372);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2373);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2374);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2375);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2376);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2377);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2378);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2379);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2380);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2381);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2382);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2383);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2384);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2385);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2386);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2387);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2388);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2389);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2390);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2391);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2392);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2393);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2394);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2395);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2396);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2397);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2398);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2399);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2400);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2401);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2402);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2403);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2404);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2405);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2406);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2407);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2408);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2409);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2410);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2411);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2412);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2413);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2414);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2415);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2416);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2417);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2418);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2419);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2420);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2421);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2422);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2423);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2424);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2425);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2426);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2427);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2428);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2429);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2430);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2431);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2432);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2433);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2434);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2435);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2436);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2437);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2438);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2439);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2440);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2441);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2442);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2443);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2444);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2445);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2446);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2447);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2448);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2449);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2450);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2451);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2452);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2453);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2454);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2455);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2456);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2457);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2458);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2459);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2460);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2461);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2462);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2463);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2464);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2465);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2466);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2467);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2468);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2469);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2470);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2471);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2472);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2473);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2474);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2475);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2476);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2477);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2478);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2479);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2480);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2481);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2482);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2483);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2484);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2485);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2486);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2487);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2488);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2489);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2490);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2491);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2492);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2493);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2494);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2495);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2496);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2497);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2498);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2499);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2500);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2501);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2502);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2503);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2504);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2505);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2506);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2507);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2508);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2509);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2510);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2511);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2512);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2513);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2514);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2515);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2516);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2517);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2518);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2519);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2520);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2521);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2522);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2523);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2524);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2525);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2526);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2527);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2528);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2529);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2530);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2531);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2532);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2533);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2534);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2535);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2536);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2537);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2538);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2539);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2540);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2541);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2542);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2543);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2544);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2545);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2546);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2547);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2548);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2549);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2550);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2551);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2552);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2553);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2554);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2555);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2556);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2557);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2558);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2559);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2560);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2561);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2562);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2563);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2564);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2565);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2566);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2567);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2568);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2569);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2570);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2571);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2572);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2573);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2574);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2575);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2576);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2577);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2578);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2579);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2580);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2581);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2582);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2583);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2584);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2585);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2586);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2587);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2588);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2589);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2590);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2591);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2592);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2593);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2594);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2595);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2596);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2597);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2598);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2599);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2600);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2601);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2602);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2603);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2604);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2605);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2606);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2607);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2608);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2609);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2610);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2611);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2612);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2613);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2614);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2615);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2616);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2617);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2618);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2619);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2620);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2621);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2622);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2623);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2624);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2625);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2626);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2627);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2628);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2629);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2630);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2631);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2632);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2633);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2634);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2635);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2636);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2637);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2638);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2639);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2640);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2641);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2642);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2643);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2644);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2645);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2646);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2647);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2648);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2649);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2650);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2651);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2652);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2653);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2654);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2655);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2656);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2657);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2658);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2659);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2660);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2661);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2662);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2663);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2664);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2665);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2666);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2667);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2668);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2669);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2670);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2671);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2672);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2673);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2674);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2675);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2676);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2677);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2678);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2679);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2680);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2681);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2682);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2683);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2684);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2685);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2686);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2687);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2688);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2689);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2690);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2691);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2692);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2693);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2694);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2695);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2696);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2697);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2698);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2699);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2700);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2701);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2702);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2703);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2704);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2705);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2706);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2707);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2708);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2709);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2710);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2711);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2712);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2713);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2714);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2715);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2716);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2717);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2718);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2719);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2720);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2721);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2722);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2723);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2724);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2725);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2726);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2727);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2728);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2729);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2730);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2731);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2732);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2733);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2734);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2735);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2736);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2737);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2738);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2739);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2740);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2741);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2742);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2743);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2744);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2745);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2746);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2747);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2748);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2749);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2750);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2751);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2752);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2753);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2754);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2755);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2756);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2757);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2758);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2759);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2760);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2761);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2762);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2763);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2764);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2765);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2766);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2767);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2768);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2769);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2770);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2771);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2772);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2773);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2774);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2775);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2776);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2777);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2778);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2779);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2780);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2781);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2782);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2783);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2784);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2785);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2786);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2787);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2788);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2789);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2790);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2791);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2792);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2793);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2794);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2795);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2796);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2797);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2798);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2799);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2800);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2801);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2802);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2803);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2804);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2805);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2806);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2807);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2808);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2809);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2810);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2811);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2812);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2813);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2814);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2815);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2816);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2817);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2818);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2819);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2820);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2821);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2822);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2823);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2824);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2825);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2826);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2827);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2828);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2829);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2830);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2831);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2832);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2833);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2834);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2835);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2836);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2837);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2838);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2839);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2840);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2841);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2842);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2843);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2844);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2845);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2846);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2847);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2848);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2849);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2850);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2851);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2852);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2853);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2854);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2855);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2856);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2857);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2858);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2859);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2860);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2861);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2862);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2863);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2864);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2865);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2866);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2867);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2868);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2869);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2870);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2871);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2872);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2873);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2874);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2875);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2876);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2877);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2878);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2879);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2880);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2881);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2882);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2883);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2884);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2885);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2886);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2887);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2888);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2889);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2890);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2891);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2892);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2893);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2894);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2895);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2896);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2897);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2898);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2899);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2900);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2901);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2902);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2903);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2904);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2905);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2906);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2907);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2908);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2909);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2910);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2911);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2912);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2913);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2914);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2915);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2916);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2917);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2918);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2919);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2920);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2921);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2922);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2923);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2924);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2925);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2926);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2927);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2928);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2929);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2930);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2931);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2932);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2933);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2934);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2935);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2936);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2937);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2938);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2939);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2940);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2941);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2942);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2943);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2944);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2945);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2946);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2947);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2948);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2949);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2950);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2951);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2952);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2953);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2954);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2955);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2956);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2957);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2958);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2959);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2960);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2961);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2962);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2963);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2964);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2965);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2966);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2967);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2968);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2969);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2970);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2971);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2972);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2973);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2974);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2975);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2976);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2977);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2978);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2979);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2980);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2981);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2982);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2983);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2984);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2985);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2986);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2987);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2988);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2989);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2990);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2991);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2992);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2993);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2994);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2995);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2996);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2997);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2998);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 2999);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3001);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3002);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3003);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3004);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3005);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3006);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3007);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3008);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3009);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3010);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3011);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3012);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3013);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3014);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3015);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3016);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3017);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3018);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3019);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3020);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3021);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3022);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3023);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3024);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3025);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3026);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3027);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3028);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3029);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3030);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3031);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3032);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3033);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3034);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3035);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3036);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3037);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3038);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3039);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3040);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3041);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3042);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3043);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3044);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3045);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3046);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3047);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3048);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3049);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3050);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3051);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3052);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3053);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3054);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3055);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3056);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3057);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3058);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3059);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3060);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3061);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3062);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3063);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3064);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3065);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3066);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3067);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3068);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3069);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3070);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3071);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3072);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3073);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3074);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3075);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3076);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3077);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3078);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3079);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3080);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3081);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3082);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3083);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3084);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3085);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3086);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3087);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3088);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3089);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3090);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3091);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3092);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3093);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3094);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3095);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3096);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3097);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3098);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3099);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3100);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3101);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3102);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3103);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3104);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3105);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3106);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3107);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3108);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3109);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3110);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3111);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3112);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3113);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3114);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3115);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3116);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3117);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3118);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3119);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3120);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3121);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3122);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3123);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3124);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3125);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3126);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3127);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3128);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3129);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3130);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3131);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3132);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3133);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3134);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3135);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3136);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3137);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3138);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3139);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3140);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3141);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3142);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3143);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3144);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3145);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3146);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3147);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3148);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3149);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3150);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3151);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3152);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3153);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3154);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3155);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3156);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3157);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3158);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3159);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3160);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3161);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3162);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3163);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3164);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3165);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3166);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3167);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3168);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3169);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3170);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3171);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3172);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3173);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3174);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3175);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3176);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3177);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3178);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3179);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3180);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3181);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3182);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3183);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3184);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3185);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3186);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3187);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3188);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3189);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3190);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3191);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3192);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3193);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3194);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3195);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3196);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3197);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3198);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3199);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3200);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3201);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3202);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3203);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3204);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3205);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3206);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3207);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3208);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3209);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3210);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3211);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3212);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3213);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3214);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3215);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3216);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3217);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3218);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3219);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3220);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3221);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3222);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3223);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3224);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3225);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3226);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3227);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3228);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3229);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3230);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3231);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3232);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3233);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3234);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3235);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3236);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3237);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3238);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3239);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3240);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3241);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3242);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3243);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3244);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3245);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3246);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3247);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3248);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3249);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3250);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3251);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3252);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3253);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3254);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3255);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3256);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3257);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3258);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3259);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3260);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3261);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3262);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3263);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3264);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3265);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3266);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3267);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3268);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3269);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3270);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3271);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3272);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3273);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3274);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3275);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3276);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3277);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3278);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3279);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3280);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3281);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3282);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3283);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3284);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3285);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3286);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3287);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3288);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3289);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3290);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3291);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3292);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3293);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3294);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3295);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3296);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3297);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3298);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3299);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3300);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3301);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3302);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3303);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3304);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3305);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3306);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3307);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3308);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3309);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3310);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3311);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3312);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3313);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3314);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3315);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3316);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3317);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3318);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3319);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3320);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3321);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3322);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3323);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3324);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3325);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3326);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3327);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3328);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3329);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3330);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3331);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3332);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3333);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3334);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3335);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3336);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3337);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3338);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3339);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3340);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3341);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3342);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3343);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3344);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3345);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3346);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3347);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3348);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3349);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3350);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3351);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3352);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3353);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3354);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3355);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3356);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3357);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3358);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3359);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3360);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3361);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3362);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3363);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3364);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3365);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3366);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3367);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3368);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3369);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3370);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3371);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3372);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3373);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3374);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3375);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3376);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3377);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3378);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3379);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3380);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3381);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3382);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3383);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3384);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3385);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3386);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3387);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3388);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3389);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3390);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3391);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3392);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3393);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3394);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3395);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3396);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3397);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3398);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3399);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3400);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3401);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3402);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3403);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3404);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3405);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3406);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3407);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3408);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3409);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3410);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3411);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3412);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3413);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3414);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3415);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3416);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3417);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3418);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3419);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3420);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3421);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3422);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3423);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3424);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3425);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3426);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3427);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3428);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3429);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3430);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3431);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3432);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3433);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3434);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3435);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3436);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3437);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3438);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3439);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3440);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3441);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3442);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3443);

            migrationBuilder.DeleteData(
                table: "BrickCategories",
                keyColumn: "id",
                keyValue: 3444);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "NetContents",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "PackageLevels",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PackageLevels",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PackageLevels",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PackageLevels",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PackageLevels",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PackageLevels",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PackageLevels",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PackagingTypes",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "TargetMarkets",
                keyColumn: "id",
                keyValue: 894);
        }
    }
}
